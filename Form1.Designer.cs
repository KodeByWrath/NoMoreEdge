
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_install = new System.Windows.Forms.Button();
            this.btn_uninstall = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.google = new System.Windows.Forms.RadioButton();
            this.duckduckgo = new System.Windows.Forms.RadioButton();
            this.ask = new System.Windows.Forms.RadioButton();
            this.brave = new System.Windows.Forms.RadioButton();
            this.ecosia = new System.Windows.Forms.RadioButton();
            this.yahoo = new System.Windows.Forms.RadioButton();
            this.yandex = new System.Windows.Forms.RadioButton();
            this.sogou = new System.Windows.Forms.RadioButton();
            this.btn_github = new System.Windows.Forms.Button();
            this.lbl_engine = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(332, 12);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(97, 34);
            this.btn_install.TabIndex = 0;
            this.btn_install.Text = "Install";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // btn_uninstall
            // 
            this.btn_uninstall.Location = new System.Drawing.Point(332, 52);
            this.btn_uninstall.Name = "btn_uninstall";
            this.btn_uninstall.Size = new System.Drawing.Size(97, 32);
            this.btn_uninstall.TabIndex = 1;
            this.btn_uninstall.Text = "Uninstall";
            this.btn_uninstall.UseVisualStyleBackColor = true;
            this.btn_uninstall.Click += new System.EventHandler(this.btn_uninstall_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(332, 168);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 34);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(332, 90);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(97, 32);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // google
            // 
            this.google.AutoSize = true;
            this.google.BackColor = System.Drawing.Color.Transparent;
            this.google.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.google.ForeColor = System.Drawing.Color.White;
            this.google.Location = new System.Drawing.Point(40, 76);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(65, 17);
            this.google.TabIndex = 4;
            this.google.TabStop = true;
            this.google.Text = "Google";
            this.google.UseVisualStyleBackColor = false;
            this.google.CheckedChanged += new System.EventHandler(this.google_CheckedChanged);
            // 
            // duckduckgo
            // 
            this.duckduckgo.AutoSize = true;
            this.duckduckgo.BackColor = System.Drawing.Color.Transparent;
            this.duckduckgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duckduckgo.ForeColor = System.Drawing.Color.Black;
            this.duckduckgo.Location = new System.Drawing.Point(165, 122);
            this.duckduckgo.Name = "duckduckgo";
            this.duckduckgo.Size = new System.Drawing.Size(101, 17);
            this.duckduckgo.TabIndex = 5;
            this.duckduckgo.TabStop = true;
            this.duckduckgo.Text = "DuckDuckGo";
            this.duckduckgo.UseVisualStyleBackColor = false;
            this.duckduckgo.CheckedChanged += new System.EventHandler(this.duckduckgo_CheckedChanged);
            // 
            // ask
            // 
            this.ask.AutoSize = true;
            this.ask.BackColor = System.Drawing.Color.Transparent;
            this.ask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ask.ForeColor = System.Drawing.Color.White;
            this.ask.Location = new System.Drawing.Point(40, 99);
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(46, 17);
            this.ask.TabIndex = 6;
            this.ask.TabStop = true;
            this.ask.Text = "Ask";
            this.ask.UseVisualStyleBackColor = false;
            this.ask.CheckedChanged += new System.EventHandler(this.ask_CheckedChanged);
            // 
            // brave
            // 
            this.brave.AutoSize = true;
            this.brave.BackColor = System.Drawing.Color.Transparent;
            this.brave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brave.ForeColor = System.Drawing.Color.White;
            this.brave.Location = new System.Drawing.Point(40, 168);
            this.brave.Name = "brave";
            this.brave.Size = new System.Drawing.Size(57, 17);
            this.brave.TabIndex = 7;
            this.brave.TabStop = true;
            this.brave.Text = "brave";
            this.brave.UseVisualStyleBackColor = false;
            this.brave.CheckedChanged += new System.EventHandler(this.brave_CheckedChanged);
            // 
            // ecosia
            // 
            this.ecosia.AutoSize = true;
            this.ecosia.BackColor = System.Drawing.Color.Transparent;
            this.ecosia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecosia.ForeColor = System.Drawing.Color.White;
            this.ecosia.Location = new System.Drawing.Point(40, 122);
            this.ecosia.Name = "ecosia";
            this.ecosia.Size = new System.Drawing.Size(63, 17);
            this.ecosia.TabIndex = 8;
            this.ecosia.TabStop = true;
            this.ecosia.Text = "Ecosia";
            this.ecosia.UseVisualStyleBackColor = false;
            this.ecosia.CheckedChanged += new System.EventHandler(this.ecosia_CheckedChanged);
            // 
            // yahoo
            // 
            this.yahoo.AutoSize = true;
            this.yahoo.BackColor = System.Drawing.Color.Transparent;
            this.yahoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahoo.ForeColor = System.Drawing.Color.White;
            this.yahoo.Location = new System.Drawing.Point(40, 191);
            this.yahoo.Name = "yahoo";
            this.yahoo.Size = new System.Drawing.Size(61, 17);
            this.yahoo.TabIndex = 9;
            this.yahoo.TabStop = true;
            this.yahoo.Text = "Yahoo";
            this.yahoo.UseVisualStyleBackColor = false;
            this.yahoo.CheckedChanged += new System.EventHandler(this.yahoo_CheckedChanged);
            // 
            // yandex
            // 
            this.yandex.AutoSize = true;
            this.yandex.BackColor = System.Drawing.Color.Transparent;
            this.yandex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yandex.ForeColor = System.Drawing.Color.White;
            this.yandex.Location = new System.Drawing.Point(40, 145);
            this.yandex.Name = "yandex";
            this.yandex.Size = new System.Drawing.Size(67, 17);
            this.yandex.TabIndex = 10;
            this.yandex.TabStop = true;
            this.yandex.Text = "Yandex";
            this.yandex.UseVisualStyleBackColor = false;
            this.yandex.CheckedChanged += new System.EventHandler(this.yandex_CheckedChanged);
            // 
            // sogou
            // 
            this.sogou.AutoSize = true;
            this.sogou.BackColor = System.Drawing.Color.Transparent;
            this.sogou.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sogou.ForeColor = System.Drawing.Color.White;
            this.sogou.Location = new System.Drawing.Point(40, 214);
            this.sogou.Name = "sogou";
            this.sogou.Size = new System.Drawing.Size(61, 17);
            this.sogou.TabIndex = 11;
            this.sogou.TabStop = true;
            this.sogou.Text = "Sogou";
            this.sogou.UseVisualStyleBackColor = false;
            this.sogou.CheckedChanged += new System.EventHandler(this.sogou_CheckedChanged);
            // 
            // btn_github
            // 
            this.btn_github.BackColor = System.Drawing.Color.Transparent;
            this.btn_github.BackgroundImage = global::NoMoreEdgeSetup.Properties.Resources.github;
            this.btn_github.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_github.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_github.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_github.Location = new System.Drawing.Point(332, 128);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(97, 34);
            this.btn_github.TabIndex = 12;
            this.btn_github.UseVisualStyleBackColor = false;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // lbl_engine
            // 
            this.lbl_engine.BackColor = System.Drawing.Color.Transparent;
            this.lbl_engine.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_engine.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_engine.Location = new System.Drawing.Point(40, 50);
            this.lbl_engine.Name = "lbl_engine";
            this.lbl_engine.Size = new System.Drawing.Size(226, 23);
            this.lbl_engine.TabIndex = 14;
            this.lbl_engine.Text = "Select Search Engine";
            this.lbl_engine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_title.Location = new System.Drawing.Point(-1, 1);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 24);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "NoMoreEdge Setup";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "By Harshal Kudale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_engine);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_github);
            this.Controls.Add(this.sogou);
            this.Controls.Add(this.yandex);
            this.Controls.Add(this.yahoo);
            this.Controls.Add(this.ecosia);
            this.Controls.Add(this.brave);
            this.Controls.Add(this.ask);
            this.Controls.Add(this.duckduckgo);
            this.Controls.Add(this.google);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_uninstall);
            this.Controls.Add(this.btn_install);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NoMoreEdge Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_uninstall;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.RadioButton google;
        private System.Windows.Forms.RadioButton duckduckgo;
        private System.Windows.Forms.RadioButton ask;
        private System.Windows.Forms.RadioButton brave;
        private System.Windows.Forms.RadioButton ecosia;
        private System.Windows.Forms.RadioButton yahoo;
        private System.Windows.Forms.RadioButton yandex;
        private System.Windows.Forms.RadioButton sogou;
        private System.Windows.Forms.Button btn_github;
        private System.Windows.Forms.Label lbl_engine;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
    }
}

