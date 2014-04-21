 
    partial class FillderView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_drop = new System.Windows.Forms.TextBox();
            this.btn_excute = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.dg_result = new System.Windows.Forms.DataGridView();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_drop
            // 
            this.txt_drop.AllowDrop = true;
            this.txt_drop.Location = new System.Drawing.Point(3, 3);
            this.txt_drop.Multiline = true;
            this.txt_drop.Name = "txt_drop";
            this.txt_drop.Size = new System.Drawing.Size(654, 46);
            this.txt_drop.TabIndex = 0;
            this.txt_drop.Text = "please drop in a ssesion";
            this.txt_drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_drop_DragDrop);
            this.txt_drop.DragLeave += new System.EventHandler(this.txt_drop_DragLeave);
            this.txt_drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_drop_DragEnter);
            // 
            // btn_excute
            // 
            this.btn_excute.Location = new System.Drawing.Point(663, 3);
            this.btn_excute.Name = "btn_excute";
            this.btn_excute.Size = new System.Drawing.Size(75, 46);
            this.btn_excute.TabIndex = 1;
            this.btn_excute.Text = "excute";
            this.btn_excute.UseVisualStyleBackColor = true;
            this.btn_excute.Click += new System.EventHandler(this.btn_excute_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(3, 55);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_result.Size = new System.Drawing.Size(735, 311);
            this.txt_result.TabIndex = 2;
            // 
            // dg_result
            // 
            this.dg_result.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.url,
            this.state});
            this.dg_result.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg_result.Location = new System.Drawing.Point(1, 372);
            this.dg_result.Name = "dg_result";
            this.dg_result.Size = new System.Drawing.Size(735, 245);
            this.dg_result.TabIndex = 3;
            // 
            // url
            // 
            this.url.HeaderText = "Url";
            this.url.Name = "url";
            this.url.Width = 500;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            // 
            // FillderView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_result);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_excute);
            this.Controls.Add(this.txt_drop);
            this.Name = "FillderView";
            this.Size = new System.Drawing.Size(744, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dg_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox txt_drop;
        public System.Windows.Forms.Button btn_excute;
        public System.Windows.Forms.TextBox txt_result;
        public System.Windows.Forms.DataGridView dg_result;
        public  System.Windows.Forms.DataGridViewTextBoxColumn url;
        public System.Windows.Forms.DataGridViewTextBoxColumn state;
    }

