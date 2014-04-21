
partial class FidderView
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
        this.components = new System.ComponentModel.Container();
        this.txt_drop = new System.Windows.Forms.TextBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.rb_exit = new System.Windows.Forms.RadioButton();
        this.rb_access = new System.Windows.Forms.RadioButton();
        this.rb_login = new System.Windows.Forms.RadioButton();
        this.btn_excute = new System.Windows.Forms.Button();
        this.txt_result = new System.Windows.Forms.TextBox();
        this.btn_excute_time = new System.Windows.Forms.Button();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.num_interval = new System.Windows.Forms.NumericUpDown();
        this.time = new System.Windows.Forms.Timer(this.components);
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.num_interval)).BeginInit();
        this.groupBox3.SuspendLayout();
        this.SuspendLayout();
        // 
        // txt_drop
        // 
        this.txt_drop.AllowDrop = true;
        this.txt_drop.Location = new System.Drawing.Point(6, 19);
        this.txt_drop.Multiline = true;
        this.txt_drop.Name = "txt_drop";
        this.txt_drop.Size = new System.Drawing.Size(463, 49);
        this.txt_drop.TabIndex = 1;
        this.txt_drop.Text = "please drop a session";
        this.txt_drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.txt_drop_DragDrop);
        this.txt_drop.DragLeave += new System.EventHandler(this.txt_drop_DragLeave);
        this.txt_drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_drop_DragEnter);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.rb_exit);
        this.groupBox1.Controls.Add(this.rb_access);
        this.groupBox1.Controls.Add(this.rb_login);
        this.groupBox1.Location = new System.Drawing.Point(475, 16);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(179, 49);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        // 
        // rb_exit
        // 
        this.rb_exit.AutoSize = true;
        this.rb_exit.Location = new System.Drawing.Point(119, 20);
        this.rb_exit.Name = "rb_exit";
        this.rb_exit.Size = new System.Drawing.Size(47, 17);
        this.rb_exit.TabIndex = 2;
        this.rb_exit.Text = "Exist";
        this.rb_exit.UseVisualStyleBackColor = true;
        // 
        // rb_access
        // 
        this.rb_access.AutoSize = true;
        this.rb_access.Location = new System.Drawing.Point(56, 20);
        this.rb_access.Name = "rb_access";
        this.rb_access.Size = new System.Drawing.Size(60, 17);
        this.rb_access.TabIndex = 1;
        this.rb_access.Text = "Access";
        this.rb_access.UseVisualStyleBackColor = true;
        // 
        // rb_login
        // 
        this.rb_login.AutoSize = true;
        this.rb_login.Checked = true;
        this.rb_login.Location = new System.Drawing.Point(7, 20);
        this.rb_login.Name = "rb_login";
        this.rb_login.Size = new System.Drawing.Size(51, 17);
        this.rb_login.TabIndex = 0;
        this.rb_login.TabStop = true;
        this.rb_login.Text = "Login";
        this.rb_login.UseVisualStyleBackColor = true;
        // 
        // btn_excute
        // 
        this.btn_excute.Location = new System.Drawing.Point(660, 20);
        this.btn_excute.Name = "btn_excute";
        this.btn_excute.Size = new System.Drawing.Size(62, 45);
        this.btn_excute.TabIndex = 3;
        this.btn_excute.Text = "Excute";
        this.btn_excute.UseVisualStyleBackColor = true;
        this.btn_excute.Click += new System.EventHandler(this.btn_excute_Click);
        // 
        // txt_result
        // 
        this.txt_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txt_result.Location = new System.Drawing.Point(7, 93);
        this.txt_result.Multiline = true;
        this.txt_result.Name = "txt_result";
        this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.txt_result.Size = new System.Drawing.Size(843, 485);
        this.txt_result.TabIndex = 4;
        // 
        // btn_excute_time
        // 
        this.btn_excute_time.Location = new System.Drawing.Point(9, 34);
        this.btn_excute_time.Name = "btn_excute_time";
        this.btn_excute_time.Size = new System.Drawing.Size(83, 23);
        this.btn_excute_time.TabIndex = 6;
        this.btn_excute_time.Text = "Start Timer";
        this.btn_excute_time.UseVisualStyleBackColor = true;
        this.btn_excute_time.Click += new System.EventHandler(this.btn_excute_time_Click);
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.num_interval);
        this.groupBox2.Controls.Add(this.btn_excute_time);
        this.groupBox2.Location = new System.Drawing.Point(728, 10);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(100, 63);
        this.groupBox2.TabIndex = 7;
        this.groupBox2.TabStop = false;
        // 
        // num_interval
        // 
        this.num_interval.Location = new System.Drawing.Point(9, 11);
        this.num_interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
        this.num_interval.Name = "num_interval";
        this.num_interval.Size = new System.Drawing.Size(83, 20);
        this.num_interval.TabIndex = 7;
        this.num_interval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
        // 
        // time
        // 
        this.time.Tick += new System.EventHandler(this.time_Tick);
        // 
        // groupBox3
        // 
        this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox3.Controls.Add(this.txt_drop);
        this.groupBox3.Controls.Add(this.groupBox2);
        this.groupBox3.Controls.Add(this.groupBox1);
        this.groupBox3.Controls.Add(this.btn_excute);
        this.groupBox3.Location = new System.Drawing.Point(6, 3);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(844, 84);
        this.groupBox3.TabIndex = 8;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Operation";
        // 
        // FidderView
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.groupBox3);
        this.Controls.Add(this.txt_result);
        this.Name = "FidderView";
        this.Size = new System.Drawing.Size(858, 581);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.num_interval)).EndInit();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.TextBox txt_drop;
    public System.Windows.Forms.GroupBox groupBox1;
    public System.Windows.Forms.RadioButton rb_access;
    public System.Windows.Forms.RadioButton rb_login;
    public System.Windows.Forms.RadioButton rb_exit;
    public System.Windows.Forms.Button btn_excute;
    public System.Windows.Forms.TextBox txt_result;
    private System.Windows.Forms.Button btn_excute_time;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Timer time;
    private System.Windows.Forms.NumericUpDown num_interval;
    private System.Windows.Forms.GroupBox groupBox3;
}

