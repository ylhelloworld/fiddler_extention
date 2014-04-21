using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fiddler;
using System.Threading;

public partial class FidderView : UserControl
{
    public FidderView()
    {
        InitializeComponent();
    }

    public Session[] login_session;
    public Session[] access_session;
    public Session[] exit_session;

    # region  Drog OSession

    private void txt_drop_DragEnter(object sender, DragEventArgs e)
    {
        this.txt_drop.BackColor = Color.Lime;
        e.Effect = DragDropEffects.Link | DragDropEffects.Copy;
    }

    private void txt_drop_DragDrop(object sender, DragEventArgs e)
    {
        this.txt_drop.BackColor = Color.FromKnownColor(KnownColor.Control);
        Session[] session = (Session[])e.Data.GetData("Fiddler.Session[]");

        if (rb_login.Checked == true)
        {
            login_session = session;
            this.txt_result.Text += "Drop a Login Session " + Environment.NewLine;
        }
        else if (rb_exit.Checked == true)
        {
            exit_session = session;
            this.txt_result.Text += "Drop a Exit Session " + Environment.NewLine;
        }
        else if (rb_access.Checked == true)
        {
            access_session = session;
            this.txt_result.Text += "Drop a Access Session " + Environment.NewLine;
        }
    }

    private void txt_drop_DragLeave(object sender, EventArgs e)
    {
        this.txt_drop.BackColor = Color.FromKnownColor(KnownColor.Control);
    }

    # endregion

    private void btn_excute_Click(object sender, EventArgs e)
    {
        //Thread thread = new Thread(new ParameterizedThreadStart(send_request));
        Thread thread = new Thread(new ThreadStart(send_request));
        this.txt_result.Text += "[ID:" + thread.ManagedThreadId.ToString() + "]  Start Sending...." + Environment.NewLine;
        thread.Start();
    }

    private void btn_excute_time_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(this.txt_drop.Text))
        {
            int interval = (int)num_interval.Value;
            this.time.Enabled = true;
            this.time.Interval = interval;
            this.time.Start();
        }
    }

    private void time_Tick(object sender, EventArgs e)
    {
        Thread thread = new Thread(new ThreadStart(send_request_random));
        this.txt_result.Text += "[ID:" + thread.ManagedThreadId.ToString() + "]  Start Sending...." + Environment.NewLine;
        thread.Start();
    }

    public void send_request()
    {
        Session from_session;
        if (rb_login.Checked == true)
        {
            from_session = login_session[0];
        }
        else if (rb_exit.Checked == true)
        {
            from_session = exit_session[0];
        }
        else
        {
            from_session = access_session[0];
        }
        if (from_session.oFlags["AutoRequest"] == null)
        {
            from_session.oFlags.Add("AutoRequest", "AutoRequest");
        }
        Fiddler.FiddlerApplication.oProxy.SendRequest(from_session.oRequest.headers, from_session.requestBodyBytes, from_session.oFlags);
        this.txt_result.Text += "[ID:" + Thread.CurrentThread.ManagedThreadId.ToString() + "] Complete Sending" + Environment.NewLine;

    }
    public void send_request_random()
    {
        //加入随机时间，进行混淆 
        Random random = new Random();
        Thread.Sleep(random.Next((int)num_interval.Value * 2)); 

        Session from_session;
        if (rb_login.Checked == true)
        {
            from_session = login_session[0];
        }
        else if (rb_exit.Checked == true)
        {
            from_session = exit_session[0];
        }
        else
        {
            from_session = access_session[0];
        }
        if (from_session.oFlags["AutoRequest"] == null)
        {
            from_session.oFlags.Add("AutoRequest", "AutoRequest");
        }
        Fiddler.FiddlerApplication.oProxy.SendRequest(from_session.oRequest.headers, from_session.requestBodyBytes, from_session.oFlags);
        this.txt_result.Text += "[ID:" + Thread.CurrentThread.ManagedThreadId.ToString() + "] Complete Sending" + Environment.NewLine;

    }
}