using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Fiddler;
using System.IO;
using System.Threading;
[assembly: Fiddler.RequiredVersion("2.3.5.0")]
public class OneFiddler : IAutoTamper
{
    FillderView view;
    public OneFiddler()
    {
    }
    public void OnLoad()
    {
        TabPage oPage = new TabPage("Show 2R");
        oPage.ImageIndex = (int)Fiddler.SessionIcons.Silverlight;
        view = new FillderView();
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
        if (oSession.oFlags["Show2R"] != null)
        {
            this.view.txt_result.Text = "";
            this.view.txt_result.Text = this.view.txt_result.Text + oSession.oRequest.headers.ToString() + "\r\n" +
                           "=========================================================\r\n\r\n" +
                           oSession.oResponse.headers.ToString();
            DataGridViewRow row = view.dg_result.Rows[view.dg_result.Rows.Add()];
            row.Cells[0].Value = oSession.oRequest.headers.RequestPath.ToString();
            row.Cells[1].Value = oSession.oResponse.headers.HTTPResponseStatus.ToString();
        }
    }
    public void OnBeforeReturningError(Session oSession)
    {

    } 
}

