namespace wedoforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemII = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIII = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemdI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemdII = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemdIII = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemdIV = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "stone",
            "wood",
            "water",
            "fire",
            "air",
            "ice",
            "metal",
            "light"});
            this.comboBox1.Location = new System.Drawing.Point(488, 1);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown_1);
            this.comboBox1.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.comboBox1.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "gloomy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rb_click);
            this.radioButton1.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.radioButton1.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(320, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(89, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "souls";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(5, 153);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 20);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "gone";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.rb_click);
            this.radioButton6.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.radioButton6.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(5, 126);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 20);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "darker";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.rb_click);
            this.radioButton5.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.radioButton5.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 98);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 20);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "dark";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.rb_click);
            this.radioButton4.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.radioButton4.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 73);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "twilight";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rb_click);
            this.radioButton3.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.radioButton3.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 46);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "shady";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rb_click);
            this.radioButton2.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.radioButton2.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(11, 81);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 164);
            this.listBox1.TabIndex = 4;
            this.listBox1.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.listBox1.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(137, 81);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(121, 164);
            this.listBox2.TabIndex = 5;
            this.listBox2.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.listBox2.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.textBox1.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemI,
            this.ToolStripMenuItemII,
            this.ToolStripMenuItemIII,
            this.ToolStripMenuItemIV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 100);
            this.contextMenuStrip1.Text = "what";
            // 
            // ToolStripMenuItemI
            // 
            this.ToolStripMenuItemI.Name = "ToolStripMenuItemI";
            this.ToolStripMenuItemI.Size = new System.Drawing.Size(185, 24);
            this.ToolStripMenuItemI.Text = "send line";
            this.ToolStripMenuItemI.Click += new System.EventHandler(this.ToolStripMenuItemI_Click);
            // 
            // ToolStripMenuItemII
            // 
            this.ToolStripMenuItemII.Name = "ToolStripMenuItemII";
            this.ToolStripMenuItemII.Size = new System.Drawing.Size(185, 24);
            this.ToolStripMenuItemII.Text = "perish chosen";
            this.ToolStripMenuItemII.Click += new System.EventHandler(this.ToolStripMenuItemII_Click);
            // 
            // ToolStripMenuItemIII
            // 
            this.ToolStripMenuItemIII.Name = "ToolStripMenuItemIII";
            this.ToolStripMenuItemIII.Size = new System.Drawing.Size(185, 24);
            this.ToolStripMenuItemIII.Text = "[c] find match";
            this.ToolStripMenuItemIII.Click += new System.EventHandler(this.ToolStripMenuItemIII_Click);
            // 
            // ToolStripMenuItemIV
            // 
            this.ToolStripMenuItemIV.Name = "ToolStripMenuItemIV";
            this.ToolStripMenuItemIV.Size = new System.Drawing.Size(185, 24);
            this.ToolStripMenuItemIV.Text = "[g] retrieve lines";
            this.ToolStripMenuItemIV.Click += new System.EventHandler(this.ToolStripMenuItemIV_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemdI,
            this.ToolStripMenuItemdII,
            this.ToolStripMenuItemdIII,
            this.toolStripMenuItemdIV});
            this.menuStrip1.Location = new System.Drawing.Point(0, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(408, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemdI
            // 
            this.ToolStripMenuItemdI.Name = "ToolStripMenuItemdI";
            this.ToolStripMenuItemdI.Size = new System.Drawing.Size(95, 24);
            this.ToolStripMenuItemdI.Text = "send down";
            this.ToolStripMenuItemdI.Click += new System.EventHandler(this.ToolStripMenuItemdI_Click);
            this.ToolStripMenuItemdI.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.ToolStripMenuItemdI.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // ToolStripMenuItemdII
            // 
            this.ToolStripMenuItemdII.Name = "ToolStripMenuItemdII";
            this.ToolStripMenuItemdII.Size = new System.Drawing.Size(63, 24);
            this.ToolStripMenuItemdII.Text = "perish";
            this.ToolStripMenuItemdII.Click += new System.EventHandler(this.ToolStripMenuItemdII_Click);
            this.ToolStripMenuItemdII.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.ToolStripMenuItemdII.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // ToolStripMenuItemdIII
            // 
            this.ToolStripMenuItemdIII.Name = "ToolStripMenuItemdIII";
            this.ToolStripMenuItemdIII.Size = new System.Drawing.Size(110, 24);
            this.ToolStripMenuItemdIII.Text = "[c] send right";
            this.ToolStripMenuItemdIII.Click += new System.EventHandler(this.ToolStripMenuItemdIII_Click);
            this.ToolStripMenuItemdIII.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.ToolStripMenuItemdIII.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // toolStripMenuItemdIV
            // 
            this.toolStripMenuItemdIV.Name = "toolStripMenuItemdIV";
            this.toolStripMenuItemdIV.Size = new System.Drawing.Size(133, 24);
            this.toolStripMenuItemdIV.Text = "[d] retrieve AGM";
            this.toolStripMenuItemdIV.Click += new System.EventHandler(this.toolStripMenuItemdIV_Click);
            this.toolStripMenuItemdIV.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.toolStripMenuItemdIV.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 255);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 16);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(415, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.textBox2.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(415, 81);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(179, 164);
            this.listBox3.TabIndex = 13;
            this.listBox3.MouseEnter += new System.EventHandler(this.hi_mouse);
            this.listBox3.MouseLeave += new System.EventHandler(this.bye_mouse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(607, 277);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "praise the form!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemII;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIII;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemdI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemdII;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemdIII;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemdIV;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

