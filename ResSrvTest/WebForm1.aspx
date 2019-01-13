<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="ResSrvTest.WebForm1" %>
<%@ Register TagPrefix="EWRP" Namespace="ResServerTest.Web.Controls" Assembly="ResServerTest.Web.Controls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>WebForm1</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>

<body >

<form id="Form1" method="post" runat="server">

Click <asp:HyperLink id="hlArticle" runat="server" Text="here" /> to read the article.<br><br>

<EWRP:DemoCustomControl id="dccTest" runat="server" />
<br><br>
You can also load resources in the application pages:<br>

<input type="button" id="btnXML" value="Get XML"
    title="Display dynamic XML"
    onclick="JavaScript:funShowXML(); return false;" >

<br><br>
A shared image: <img src="ResServerTest.Web.Controls.aspx?Res=FitHeight.bmp" alt="Shared image">

<br><br>
Loading image from a different assembly: <asp:Image id="imgOtherAsm" runat="server" />

<br><br>
A bad image name: <img src="ResServerTest.Web.Controls.aspx?Res=DoesNotExist.bmp" alt="Missing">

<br><br>
Demonstrate a bad XML request:<br>
<input type="button" id="btnXML" value="Bad XML"
    title="Display dynamic XML"
    onclick="JavaScript:funMissingXML(); return false;" >

</form>

<script type='text/javascript'>
<!--
// Demonstrate the loading of uncached, dynamic resources outside the
// control class.  This gets some XML from the resource server page.
function funShowXML()
{
	window.open('ResServerTest.Web.Controls.aspx?Res=Demo.xml&NoCache=1', null,
        'menubar=no,personalbar=no,resizable=yes,scrollbars=yes,status=no,' +
		'toolbar=no,screenX=50,screenY=50,height=400,width=800').focus()
}

// Demonstrate a missing XML resource or bad response.
function funMissingXML()
{
	window.open('ResServerTest.Web.Controls.aspx?Res=Missing.xml&NoCache=1', null,
        'menubar=no,personalbar=no,resizable=yes,scrollbars=yes,status=no,' +
		'toolbar=no,screenX=50,screenY=50,height=400,width=800').focus()
}

//-->
</script>

</body>
</HTML>
