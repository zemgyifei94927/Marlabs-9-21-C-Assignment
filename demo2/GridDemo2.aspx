<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridDemo2.aspx.cs" Inherits="demo2.GridDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family:Arial">
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3"
                AllowSorting="true" AllowPaging="true" PageSize="3" AutoGenerateColumns="false"
                DataKeyNames="Id" Width="905px" OnPageIndexChanging="GridView1_PageIndexChanging" OnPageIndexChanged="GridView1_PageIndexChanged" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" Height="290px" OnRowUpdating="GridView1_RowUpdating" >

                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />

                <Columns>

                    <asp:BoundField DataField="Name" HeaderText="PRODUCT" SortExpression="Name"/>

                    <asp:TemplateField HeaderText="DESCRIPTION" SortExpression="Description">
                        <ItemTemplate>
                            <%# Eval("Description") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="DescriptionTB" runat="server"
                                Text='<%# Bind("Description") %>'>
                            </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="UnitPrice" HeaderText="UNIT PRICE" SortExpression="UnitPrice"/>

                    <asp:TemplateField HeaderText="QTYAVAILABLE" SortExpression="QtyAvailable">
                        <ItemTemplate>
                            <%# Eval("QtyAvailable") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="QtyAvailableTB" runat="server"
                                Text='<%# Bind("QtyAvailable") %>'>
                            </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField HeaderText="ACTIONS" ShowCancelButton="true" ShowDeleteButton="true" 
                        ShowEditButton="true" ShowSelectButton="true"/>

                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
