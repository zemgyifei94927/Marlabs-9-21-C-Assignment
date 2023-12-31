using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

Console.WriteLine("Azure Blob Storage exercise\n");

// Run the examples asynchronously, wait for the results before proceeding
ProcessAsync().GetAwaiter().GetResult();

Console.WriteLine("Press enter to exit the sample application.");
Console.ReadLine();

static async Task ProcessAsync()
{
    // Copy the connection string from the portal in the variable below.
    string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=yifeiblobacct;AccountKey=bnrSB2sgdjqscAS31jBiVu/b4fPZ5VpnUh+bq0VZnp8teInHdl4rAVUzPSSAa3sY8mBOkS8ry3Cm+ASt/08K6Q==;EndpointSuffix=core.windows.net";

    // Create a client that can authenticate with a connection string
    BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);

    // Create a container
    string containerName = "wtblob" + Guid.NewGuid().ToString();
    BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
    Console.WriteLine("A container named '" + containerName + "' has been created. " +
    "\nTake a minute and verify in the portal." + 
    "\nNext a file will be created and uploaded to the container.");
    Console.WriteLine("Press 'Enter' to continue.");
    Console.ReadLine();

    // Upload files to a blob to the previous container, if the blob does not exists will create one.
    string localPath = "./data/";
    string fileName = "wtfile" + Guid.NewGuid().ToString() + ".txt";
    string localFilePath = Path.Combine(localPath, fileName);

    await File.WriteAllTextAsync(localFilePath, "Hello everyone, this is Yifei creating local files.");
    BlobClient blobClient = containerClient.GetBlobClient(fileName);

    Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

    using(FileStream uploadFileStream = File.OpenRead(localFilePath)){
        await blobClient.UploadAsync(uploadFileStream);
        uploadFileStream.Close();
    }

    Console.WriteLine("\nThe file was uploaded. We'll verify by listing" + 
        " the blobs next.");
    Console.WriteLine("Press 'Enter' to continue.");
    Console.ReadLine();

    // Get list of blobs inside the container
    Console.WriteLine("Listing blobs...");
    await foreach(BlobItem blobItem in containerClient.GetBlobsAsync()){
        Console.WriteLine("\t" + blobItem.Name);
    }

    Console.WriteLine("\nYou can also verify by looking inside the " + 
        "container in the portal." +
        "\nNext the blob will be downloaded with an altered file name.");
    Console.WriteLine("Press 'Enter' to continue.");
    Console.ReadLine();

    // Download blobs from container
    string downloadFilePath = localFilePath.Replace(".txt", "DownLOADED.txt");
    Console.WriteLine("\nDownloading blob to\n\t{0}\n", downloadFilePath);

    BlobDownloadInfo download = await blobClient.DownloadAsync();

    using(FileStream downloadFileStream = File.OpenWrite(downloadFilePath)){
        await download.Content.CopyToAsync(downloadFileStream);
    }

    Console.WriteLine("\nLocate the local file in the data directory created earlier to verify it was downloaded.");
    Console.WriteLine("The next step is to delete the container and local files.");
    Console.WriteLine("Press 'Enter' to continue.");
    Console.ReadLine();

    // Delete the container
    Console.WriteLine("\n\nDeleting blob container...");
    await containerClient.DeleteAsync();

    Console.WriteLine("Deleting the local source and downloaded files...");
    File.Delete(localFilePath);
    File.Delete(downloadFilePath);

    Console.WriteLine("Finished cleaning up.");
}
