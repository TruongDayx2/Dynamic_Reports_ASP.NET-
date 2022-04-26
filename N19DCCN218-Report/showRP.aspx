<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showRP.aspx.cs" Inherits="N19DCCN218_Report.showRP" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        TRANG BÁO CÁO
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" Height="1100px" Theme="SoftOrange" Width="100%">
        </dx:ASPxDocumentViewer>
    </div>
    </form>
</body>
</html>
