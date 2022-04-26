<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateRP.aspx.cs" Inherits="N19DCCN218_Report.CreateRP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BÁO CÁO</title>
    <style>
        body{
            background-color:#C6E2FF;
        }
        .button {
            color: black;
            border-radius: 6px;
            background-color:#FAFAD2;
        }
        .button:hover {
            background-color:#CD853F;
            color: black;
        }
        #column-content{
            position:absolute;
        }
        .auto-style1 {
            left: 262px;
            top: 56px;
            height: 134px;
            width: 1230px;
        }
        .cblColumn{
            position:absolute;
        }
        .auto-style2 {
            position: absolute;
            left: 0px;
            top: 70px;
        }
        .auto-style3 {
            position: absolute;
            left: 140px;
            top: 70px;
            width: 140px;
          
        }
        .auto-style4 {
            position: absolute;
            left: 280px;
            top: 70px;
            width: 140px;
        }
        .auto-style5 {
            position: absolute;
            left: 400px;
            top: 70px;
            width: 140px;
        }
        .auto-style6 {
            position: absolute;
            left: 510px;
            top: 70px;
            width: 140px;         
        }
        .auto-style7 {
            position: absolute;
            left: 630px;
            top: 70px;
            width: 140px;  
        }
        .auto-style8 {
            position: absolute;
            left: 760px;
            top: 70px;
            width: 140px;
        }
        .auto-style9 {
            position: absolute;
            left: 900px;
            top: 70px;
            width: 140px;
        }
        .auto-style10 {
            position: absolute;
            left: 1030px;
            top: 70px;
            width: 140px;
        }
        .auto-style11 {
            position: absolute;
            left: 1150px;
            top: 70px;
            width: 140px;
        }
        .lb1{           
            position:absolute;
            left: 0px;
            top: 50px;
        }
        .lb2{
            position:absolute;
            left: 140px;
            top: 50px;
        }
        .lb3{
            position:absolute;
            left: 280px;
            top: 50px;
        }
        .lb4{
            position:absolute;
            left: 400px;
            top: 50px;
        }
        .lb5{
            position:absolute;
            left: 510px;
            top: 50px;
        }
        .lb6{
            position:absolute;
            left: 630px;
            top: 50px;
        }
        .lb7{
            position:absolute;
            left: 760px;
            top: 50px; 
        }
        .lb8{
            position:absolute;
            left: 900px;
            top: 50px; 
        }
        .lb9{
            position:absolute;
            left: 1030px;
            top: 50px;
        }
        .lb10{
            position:absolute;
            left: 1150px;
            top: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <asp:Label ID="LabelTitle" runat="server" Text="Nhập tiêu đề báo cáo: " Font-Bold="true" Font-Size="Large" ForeColor="red" ></asp:Label>
            <asp:TextBox ID="tbTieuDe" runat="server" Width="916px" Font-Size="Large"></asp:TextBox>    
        </div>
            
        <div id="main">
            <%--Tạo bảng--%>
            <div style="display: flex;">
                <div id="table-content">
                    <asp:Panel ID="PanelChonBang" runat="server" Width="289px">
                        <br />
                        <br />
                        <asp:Label ID="LabelChonBang" runat="server" Text=" Chọn bảng " Font-Bold="true" Font-Size="Large"></asp:Label>
                        <br />
                        <asp:CheckBoxList ID="CheckBoxListTable" runat="server" Height="20px"  Width="268px" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxListTable_SelectedIndexChanged">
                        </asp:CheckBoxList>
                        <br />
                    </asp:Panel>
                </div>
            </div>
            <%--Tạo cột--%>
            <div id="column-content" class="auto-style1">
                <asp:Panel ID="PanelChonCot" runat="server" Width="1202px" Height="131px">
                    <br />
                    <asp:Label ID="LabelChonCot" runat="server" Text=" Chọn cột " Font-Bold="true"  Font-Size="Large"></asp:Label>
                    <br />
                    
                    <asp:Label ID="Label1" runat="server" Text="" cssClass="lb1" Font-Bold="True"></asp:Label>                   
                    <asp:Label ID="Label2" runat="server" Text="" CssClass="lb2" Font-Bold="True"></asp:Label>        
                    <asp:Label ID="Label3" runat="server" Text="" cssClass="lb3" Font-Bold="True"></asp:Label>               
                    <asp:Label ID="Label4" runat="server" Text="" cssClass="lb4" Font-Bold="True"></asp:Label>                    
                    <asp:Label ID="Label5" runat="server" Text="" cssClass="lb5" Font-Bold="True"></asp:Label>                   
                    <asp:Label ID="Label6" runat="server" Text="" cssClass="lb6" Font-Bold="True"></asp:Label>                    
                    <asp:Label ID="Label7" runat="server" Text="" cssClass="lb7" Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label8" runat="server" Text="" cssClass="lb8" Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label9" runat="server" Text="" cssClass="lb9" Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label10" runat="server" Text="" cssClass="lb10" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <asp:CheckBoxList ID="CBLColumn1" runat="server" CssClass="auto-style2" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn1_SelectedIndexChanged" >         
                    </asp:CheckBoxList>   
                    <asp:CheckBoxList ID="CBLColumn2" runat="server" CssClass="auto-style3" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn2_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <asp:CheckBoxList ID="CBLColumn3" runat="server" CssClass="auto-style4" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn3_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <asp:CheckBoxList ID="CBLColumn4" runat="server" CssClass="auto-style5" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn4_SelectedIndexChanged" >         
                    </asp:CheckBoxList>
                    <asp:CheckBoxList ID="CBLColumn5" runat="server" CssClass="auto-style6" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn5_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <asp:CheckBoxList ID="CBLColumn6" runat="server" CssClass="auto-style7" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn6_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <asp:CheckBoxList ID="CBLColumn7" runat="server" CssClass="auto-style8" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn7_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <asp:CheckBoxList ID="CBLColumn8" runat="server" CssClass="auto-style9" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn8_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <asp:CheckBoxList ID="CBLColumn9" runat="server" CssClass="auto-style10" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn9_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <asp:CheckBoxList ID="CBLColumn10" runat="server" CssClass="auto-style11" Height="20px" Width="162px" AutoPostBack="True" OnSelectedIndexChanged="CBLColumn10_SelectedIndexChanged" >         
                    </asp:CheckBoxList> 
                    <br />   
                </asp:Panel>
            </div>

        </div>
        <br />
        <br />
         <div id="query-content">
            <asp:Panel ID="PanelGridViewColumn" runat="server">  
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" Height="16px" Width="700px" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Sắp xếp" >
                            <ItemTemplate>
                                <asp:DropDownList ID="DropDownList_Sort" runat="server" >
                                    <asp:ListItem Text="Không" Value="None"></asp:ListItem>
                                    <asp:ListItem Text="Tăng dần" Value="ASC"></asp:ListItem>
                                    <asp:ListItem Text="Giảm dần" Value="DESC"></asp:ListItem>
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>  
                        <asp:TemplateField HeaderText="Hàm" >
                            <ItemTemplate>
                                <asp:DropDownList ID="DropDownList_Function" runat="server" >
                                    <asp:ListItem Text="Group by" Value="Group by"></asp:ListItem>
                                    <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                                    <asp:ListItem Text="Count" Value="Count"></asp:ListItem>
                                    <asp:ListItem Text="Sum" Value="Sum"></asp:ListItem>
                                    <asp:ListItem Text="Min" Value="Min"></asp:ListItem>
                                    <asp:ListItem Text="Max" Value="Max"></asp:ListItem>                                     
                                    <asp:ListItem Text="Avg" Value="Avg"></asp:ListItem>
                                    
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>          
                        <asp:TemplateField HeaderText="Điều Kiện">
                            <ItemTemplate>
                                <asp:TextBox ID="txtDieuKien" runat="server"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507C7E" ForeColor="White" HorizontalAlign="Left" Font-Bold="True"/>
                    <HeaderStyle BackColor="#507C7E" Font-Bold="true" ForeColor="White"/>
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center"/>
                    <RowStyle BackColor="#9FB6CD"/>
                    <SelectedRowStyle BackColor="#D1DDF1" ForeColor="#333333" Font-Bold="true"/>
                    <SortedAscendingCellStyle BackColor="#F5F7FB"/>
                    <SortedAscendingHeaderStyle BackColor="#507C78"/>
                    <SortedAscendingCellStyle BackColor="#007DBB"/>
                    <SortedDescendingCellStyle BackColor="#E9EBEF"/>
                    <SortedDescendingHeaderStyle BackColor="#4870BE"/>
                </asp:GridView>
                <br />
                <asp:Button ID="ButtonClearColumn" runat="server" CssClass="button" OnClick="ButtonClearColumn_Click" Text="Bỏ chọn tất cả cột" />
                
                <asp:Button ID="ButtonQuery" runat="server" CssClass="button" OnClick="ButtonQuery_Click" Text="Tạo QUERY" />
                <br />
                <br />
                <asp:TextBox ID="txtQuery" runat="server" Rows="5" TextMode="MultiLine" Width="1300px"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:Button ID="btnCreateRP" runat="server" CssClass="button" OnClick="btnCreateRP_Click" Text="Tạo Report" Width="128px" />
                <br />
                <br />
                   
            </asp:Panel>
        </div>
    
    </form>
</body>
</html>
