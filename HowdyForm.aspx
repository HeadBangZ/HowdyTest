<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HowdyForm.aspx.cs" Inherits="HowdyProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Howdy</title>
	<link href="styles/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<h1 class="header-text">Welcome to Micro Howdy!</h1>
			<div class="context-wrapper">
				
				<asp:Label ID="lb_taglineText" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="Do you feel groovy?"></asp:Label>
				<br />
				<br />
				<asp:Button ID="tryAgainBtn" CssClass="btn" runat="server" Text="Try Again?" OnClick="tryAgainBtn_Click" Visible="False" />
				<br />
				
				<br />
				<asp:Button ID="btnOne" CssClass="btn" runat="server" Text="Keep on dreamin'" OnClick="btnOne_Click" />
				<br />
				<br />
				<asp:Button ID="btnTwo" CssClass="btn" runat="server" Text="You know it!" OnClick="btnTwo_Click" />
				<br />
				<br />
				<asp:Button ID="btnThree" CssClass="btn" runat="server" Text="Off the hook" OnClick="btnThree_Click" />
				<br />
				<br />
				<asp:Label ID="clickCounterValue" runat="server" Visible="False"></asp:Label>
				<br />
				<br />
				<asp:Label ID="pointCount" runat="server" Visible="False">0</asp:Label>
			</div>
        </div>

    </form>
</body>
</html>
