using System;
using System.Windows.Forms;
using Fiddler;
using System.IO;
using System.Threading;
[assembly: Fiddler.RequiredVersion("2.3.5.0")] 
public class AutoRequest : IAutoTamper
{

    public AutoRequest()
    {
    }
    public FidderView view;
    public void OnLoad()
    {  
        TabPage oPage = new TabPage("Auto Request");
        oPage.ImageIndex = (int)Fiddler.SessionIcons.Silverlight; 
        view = new FidderView();
        oPage.Controls.Add(view);
        view.Dock = DockStyle.Fill;
        FiddlerApplication.UI.tabsViews.TabPages.Add(oPage);
    }
    public void OnBeforeUnload()
    {

    }

    public void AutoTamperRequestBefore(Session oSession)
    {

    }
    public void AutoTamperRequestAfter(Session oSession)
    {

    }
    public void AutoTamperResponseBefore(Session oSession)
    {

    }
    public void AutoTamperResponseAfter(Session oSession)
    {
        if (oSession.oFlags["AutoRequest"] != null)
        {
            view.txt_result.Text += "Response state:" + oSession.oResponse.headers.HTTPResponseStatus.ToString() + Environment.NewLine;
        }
    }
    public void OnBeforeReturningError(Session oSession)
    {

    }
}
