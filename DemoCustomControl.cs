//=============================================================================
// System  : Web Control With Resource Server Handler
// File    : DemoCustomControl.cs
// Author  : Eric Woodruff
// Updated : 04/02/2006
// Compiler: Microsoft Visual C#
//
// A demo web control used to show how the resource server handler works.
//
// This code may be used in compiled form in any way you desire.  This
// file may be redistributed by any means in modified or unmodified form
// PROVIDING that this notice and the author's name and any copyright
// notices remain intact.
//
// This file is provided "as is" with no warranty either express or
// implied.  The author accepts no liability for any damage or loss of
// business that this product may cause.
//
// Version     Date     Who  Comments
// ============================================================================
// 1.0.0    03/30/2003  EFW  Created the code
// 1.0.1    04/07/2003  EFW  Converted handler from Web.UI.Page to IHttpHandler
//=============================================================================

using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.ComponentModel;

namespace ResServerTest.Web.Controls
{
	/// <summary>
	/// A test control used to demonstrate the resource server page class.
	/// </summary>
	[ToolboxData("<{0}:DemoCustomControl runat=server />")]
	public class DemoCustomControl : System.Web.UI.Control
	{
        //=====================================================================
        // Methods, etc

        /// <summary>
        /// OnPreRender is overridden to create the child controls and set
        /// all of their attributes.
        /// </summary>
        protected override void OnPreRender(System.EventArgs e)
        {
            HtmlImage img;

            // Don't do anything if not visible
            if(this.Visible == false)
                return;

            // Just a place holder for the demo.  Use the styles
            // retrieved from the resource server handler.
            this.Controls.Add(new LiteralControl(
                "<div style='height: 300px; width: 300px; " +
                "border: black 1px solid'>Something really " +
                "<span class='Style1'>cool</span> " +
                "would go here for a <span class='Style2'>" +
                "real control</span></div>"));

            // Put the buttons below the main control
            this.Controls.Add(new LiteralControl("<br>&nbsp;\n"));

            // Add each of the image controls that represent the action buttons
            // used to interact with the control.

            // Fit to height
            img = new HtmlImage();
            img.Align = "center";
            img.Height = img.Width = 30;
            img.Style.Add("cursor", "hand");

            // Renders as:
            // src="ResServerTest.Web.Controls.aspx?Res=FitHeight.bmp"
            img.Src = ResSrvHandler.ResourceUrl("FitHeight.bmp", true);

            img.Alt = "Fit to height";

            // Call a function in the client-side script code registered below
            img.Attributes["onclick"] = "javascript: FitToHeight()";
            this.Controls.Add(img);

            // Put a space between each button
            this.Controls.Add(new LiteralControl("&nbsp;\n"));

            // Fit to width
            img = new HtmlImage();
            img.Align = "center";
            img.Height = img.Width = 30;
            img.Style.Add("cursor", "hand");
            img.Src = ResSrvHandler.ResourceUrl("FitWidth.bmp", true);
            img.Alt = "Fit to width";
            img.Attributes["onclick"] = "javascript: FitToWidth()";
            this.Controls.Add(img);
            this.Controls.Add(new LiteralControl("&nbsp;\n"));

            // Zoom in
            img = new HtmlImage();
            img.Align = "center";
            img.Height = img.Width = 30;
            img.Style.Add("cursor", "hand");
            img.Src = ResSrvHandler.ResourceUrl("ZoomIn.bmp", true);
            img.Alt = "Zoom in";
            img.Attributes["onclick"] = "javascript: ZoomIn()";
            this.Controls.Add(img);
            this.Controls.Add(new LiteralControl("&nbsp;\n"));

            // Zoom out
            img = new HtmlImage();
            img.Align = "center";
            img.Height = img.Width = 30;
            img.Style.Add("cursor", "hand");
            img.Src = ResSrvHandler.ResourceUrl("ZoomOut.bmp", true);
            img.Alt = "Zoom out";
            img.Attributes["onclick"] = "javascript: ZoomOut()";
            this.Controls.Add(img);
            this.Controls.Add(new LiteralControl("&nbsp;\n"));

            // Rotate image
            img = new HtmlImage();
            img.Align = "center";
            img.Height = img.Width = 30;
            img.Style.Add("cursor", "hand");
            img.Src = ResSrvHandler.ResourceUrl("Rotate.bmp", true);
            img.Alt = "Rotate image";
            img.Attributes["onclick"] = "javascript: Rotate(90.0)";
            this.Controls.Add(img);
            this.Controls.Add(new LiteralControl("&nbsp;\n"));

            // Print image
            img = new HtmlImage();
            img.Align = "center";
            img.Height = img.Width = 30;
            img.Style.Add("cursor", "hand");
            img.Src = ResSrvHandler.ResourceUrl("Print.bmp", true);
            img.Alt = "Print image";
            img.Attributes["onclick"] = "javascript: PrintImage()";
            this.Controls.Add(img);

            if(!Page.IsClientScriptBlockRegistered("Demo_Startup"))
            {
                // Register the client-side script module
                // Renders as: <script type='text/javascript'
                // src='ResServerTest.Web.Controls.aspx?Res=DemoCustomControl.js'>
                // </script>
                this.Page.RegisterStartupScript("Demo_Startup",
                    "<script type='text/javascript' src='" +
                    ResSrvHandler.ResourceUrl("DemoCustomControl.js", true) +
                    "'></script>");

                // Register the style sheet
                // Renders as: <link rel='stylesheet' type='text/css'
                // href='ResServerTest.Web.Controls.aspx?Res=Styles.css'>
                this.Page.RegisterClientScriptBlock("Demo_Styles",
                    "<link rel='stylesheet' type='text/css' href='" +
                    ResSrvHandler.ResourceUrl("Styles.css", true) + "'>");
            }

            base.OnPreRender(e);
        }
    }
}
