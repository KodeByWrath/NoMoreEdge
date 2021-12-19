
namespace NoMoreEdgeSetup
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
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_uninstall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custom = new System.Windows.Forms.RadioButton();
            this.predefined = new System.Windows.Forms.RadioButton();
            this.Eng_btn = new System.Windows.Forms.Button();
            this.custom_engine = new System.Windows.Forms.TextBox();
            this.EngineList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bang_box = new System.Windows.Forms.CheckBox();
            this.Edge_box = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_install
            // 
            this.btn_install.BackColor = System.Drawing.Color.Black;
            this.btn_install.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_install.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_install.Location = new System.Drawing.Point(592, 366);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(168, 61);
            this.btn_install.TabIndex = 0;
            this.btn_install.Text = "Install";
            this.btn_install.UseVisualStyleBackColor = false;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_uninstall
            // 
            this.btn_uninstall.BackColor = System.Drawing.Color.Black;
            this.btn_uninstall.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uninstall.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_uninstall.Location = new System.Drawing.Point(592, 368);
            this.btn_uninstall.Name = "btn_uninstall";
            this.btn_uninstall.Size = new System.Drawing.Size(168, 61);
            this.btn_uninstall.TabIndex = 1;
            this.btn_uninstall.Text = "Uninstall";
            this.btn_uninstall.UseVisualStyleBackColor = false;
            this.btn_uninstall.Click += new System.EventHandler(this.btn_uninstall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custom);
            this.groupBox1.Controls.Add(this.predefined);
            this.groupBox1.Controls.Add(this.custom_engine);
            this.groupBox1.Controls.Add(this.EngineList);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 139);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Engine";
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custom.Location = new System.Drawing.Point(6, 87);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(218, 26);
            this.custom.TabIndex = 7;
            this.custom.TabStop = true;
            this.custom.Text = "Custom Engine Query";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.CheckedChanged += new System.EventHandler(this.custom_CheckedChanged);
            // 
            // predefined
            // 
            this.predefined.AutoSize = true;
            this.predefined.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predefined.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.predefined.Location = new System.Drawing.Point(7, 40);
            this.predefined.Name = "predefined";
            this.predefined.Size = new System.Drawing.Size(128, 26);
            this.predefined.TabIndex = 6;
            this.predefined.TabStop = true;
            this.predefined.Text = "PreDefined";
            this.predefined.UseVisualStyleBackColor = true;
            this.predefined.CheckedChanged += new System.EventHandler(this.predefined_CheckedChanged);
            // 
            // Eng_btn
            // 
            this.Eng_btn.BackColor = System.Drawing.Color.Black;
            this.Eng_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eng_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Eng_btn.Location = new System.Drawing.Point(386, 370);
            this.Eng_btn.Name = "Eng_btn";
            this.Eng_btn.Size = new System.Drawing.Size(168, 59);
            this.Eng_btn.TabIndex = 5;
            this.Eng_btn.Text = "Update";
            this.Eng_btn.UseVisualStyleBackColor = false;
            this.Eng_btn.Click += new System.EventHandler(this.Eng_btn_Click);
            // 
            // custom_engine
            // 
            this.custom_engine.Location = new System.Drawing.Point(374, 87);
            this.custom_engine.MaxLength = 50;
            this.custom_engine.Name = "custom_engine";
            this.custom_engine.Size = new System.Drawing.Size(374, 32);
            this.custom_engine.TabIndex = 4;
            this.custom_engine.TextChanged += new System.EventHandler(this.custom_engine_TextChanged);
            // 
            // EngineList
            // 
            this.EngineList.BackColor = System.Drawing.Color.DimGray;
            this.EngineList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EngineList.FormattingEnabled = true;
            this.EngineList.Items.AddRange(new object[] {
            "Ask",
            "Bing",
            "Brave",
            "DuckDuckGo",
            "Ecosia",
            "Google",
            "Sogou",
            "Yadex"});
            this.EngineList.Location = new System.Drawing.Point(374, 40);
            this.EngineList.Name = "EngineList";
            this.EngineList.Size = new System.Drawing.Size(374, 32);
            this.EngineList.TabIndex = 1;
            this.EngineList.SelectedIndexChanged += new System.EventHandler(this.EngineList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bang_box);
            this.groupBox2.Controls.Add(this.Edge_box);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 86);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // Bang_box
            // 
            this.Bang_box.AutoSize = true;
            this.Bang_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bang_box.Location = new System.Drawing.Point(164, 32);
            this.Bang_box.Name = "Bang_box";
            this.Bang_box.Size = new System.Drawing.Size(137, 28);
            this.Bang_box.TabIndex = 10;
            this.Bang_box.Text = "DDG Bangs";
            this.Bang_box.UseVisualStyleBackColor = true;
            this.Bang_box.CheckedChanged += new System.EventHandler(this.Bang_box_CheckedChanged);
            // 
            // Edge_box
            // 
            this.Edge_box.AutoSize = true;
            this.Edge_box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edge_box.Location = new System.Drawing.Point(7, 32);
            this.Edge_box.Name = "Edge_box";
            this.Edge_box.Size = new System.Drawing.Size(137, 28);
            this.Edge_box.TabIndex = 9;
            this.Edge_box.Text = "Keep Edge";
            this.Edge_box.UseVisualStyleBackColor = true;
            this.Edge_box.CheckedChanged += new System.EventHandler(this.Edge_box_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 110);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Redirects(in progress)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(7, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 28);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Search";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(575, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(173, 28);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "WebView Apps";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox3.Location = new System.Drawing.Point(136, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(113, 28);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Widgets";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox5.Location = new System.Drawing.Point(273, 32);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(137, 28);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Spotlight";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox7.Location = new System.Drawing.Point(445, 32);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(113, 28);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "BingBar";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(785, 437);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Eng_btn);
            this.Controls.Add(this.btn_uninstall);
            this.Controls.Add(this.btn_install);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "NoMoreEdge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_uninstall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox EngineList;
        private System.Windows.Forms.TextBox custom_engine;
        private System.Windows.Forms.Button Eng_btn;
        private System.Windows.Forms.RadioButton custom;
        private System.Windows.Forms.RadioButton predefined;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Bang_box;
        private System.Windows.Forms.CheckBox Edge_box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

