using System;
using System.ComponentModel;
using System.Reflection;
using System.Web;

using ResServerTest.Web.Controls;

namespace ResSrvTest
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
        protected System.Web.UI.WebControls.Image imgOtherAsm;
        protected System.Web.UI.WebControls.HyperLink hlArticle;
        protected ResServerTest.Web.Controls.DemoCustomControl dccTest;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Demonstrate loading resource from another assembly.
            // In this case, the TextBox control's toolbox icon
            // from the System.Web assembly.  When retrieved from
            // a different assembly, it ignores any resource path
            // and is based on the name alone.  A path can be
            // specified if necessary to distinguish between like
            // named resources.
            imgOtherAsm.ImageUrl = ResSrvHandler.ResourceUrl(
                "System.Web", ResSrvHandler.cResSrvHandlerPageName,
                "TextBox.bmp", false);

            // This pulls the article text from the application assembly
            hlArticle.NavigateUrl = ResSrvHandler.ResourceUrl(
                Assembly.GetExecutingAssembly().GetName().Name,
                ResSrvHandler.cResSrvHandlerPageName,
                "ResSrvPage.html", false);
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
            this.Load += new System.EventHandler(this.Page_Load);

        }
		#endregion
	}
}
