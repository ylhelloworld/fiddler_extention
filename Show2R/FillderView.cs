using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data; 
using System.Text;
using System.Windows.Forms;
using Fiddler;
using System.Threading;

    public partial class FillderView : UserControl
    {
        public  Session from_session; 
        public FillderView()
        {
            InitializeComponent();
        }

        private void txt_drop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link | DragDropEffects.Copy;
            this.txt_drop.BackColor = Color.Lime;
        }

        private void txt_drop_DragDrop(object sender, DragEventArgs e)
        {
            this.txt_drop.BackColor = Color.FromKnownColor(KnownColor.Control);  

            string str_result = "";
            Session[] data = (Session[])e.Data.GetData("Fiddler.Session[]");
            foreach (Session session in data)
            { 
                str_result =session.oResponse.headers.ToString();
                from_session = session;
            }
            this.txt_result.Text = str_result; 
        }
         

        private void txt_drop_DragLeave(object sender, EventArgs e)
        {
            this.txt_drop.BackColor = Color.FromKnownColor(KnownColor.Control); 
        }

        private void btn_excute_Click(object sender, EventArgs e)
        {
            if (from_session.oFlags["Show2R"] == null)
            {
                from_session.oFlags.Add("Show2R", "Show2R");
            }
            Fiddler.FiddlerApplication.oProxy.SendRequest(from_session.oRequest.headers, from_session.requestBodyBytes, from_session.oFlags);
        } 
    }
