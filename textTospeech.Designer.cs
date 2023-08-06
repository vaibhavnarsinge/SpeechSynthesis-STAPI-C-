namespace SpeechSynthesis
{
    partial class textTospeech
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtSpeakt = new System.Windows.Forms.RichTextBox();
            this.btnspeakt = new Guna.UI2.WinForms.Guna2Button();
            this.btnpauset = new Guna.UI2.WinForms.Guna2Button();
            this.btnresumet = new Guna.UI2.WinForms.Guna2Button();
            this.btnexitt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(217, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 394);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rtSpeakt);
            this.panel1.Location = new System.Drawing.Point(40, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 326);
            this.panel1.TabIndex = 0;
            // 
            // rtSpeakt
            // 
            this.rtSpeakt.BulletIndent = 1;
            this.rtSpeakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtSpeakt.Location = new System.Drawing.Point(-2, -2);
            this.rtSpeakt.Name = "rtSpeakt";
            this.rtSpeakt.Size = new System.Drawing.Size(607, 326);
            this.rtSpeakt.TabIndex = 0;
            this.rtSpeakt.Text = "";
            this.rtSpeakt.TextChanged += new System.EventHandler(this.rtSpeakt_TextChanged);
            // 
            // btnspeakt
            // 
            this.btnspeakt.BorderColor = System.Drawing.Color.Teal;
            this.btnspeakt.BorderRadius = 10;
            this.btnspeakt.BorderThickness = 5;
            this.btnspeakt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnspeakt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnspeakt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnspeakt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnspeakt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnspeakt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnspeakt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspeakt.ForeColor = System.Drawing.Color.White;
            this.btnspeakt.Location = new System.Drawing.Point(38, 90);
            this.btnspeakt.Name = "btnspeakt";
            this.btnspeakt.Size = new System.Drawing.Size(137, 58);
            this.btnspeakt.TabIndex = 1;
            this.btnspeakt.Text = "Speak";
            this.btnspeakt.Click += new System.EventHandler(this.btnspeakt_Click);
            // 
            // btnpauset
            // 
            this.btnpauset.BorderColor = System.Drawing.Color.Teal;
            this.btnpauset.BorderRadius = 10;
            this.btnpauset.BorderThickness = 5;
            this.btnpauset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpauset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpauset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpauset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpauset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpauset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpauset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpauset.ForeColor = System.Drawing.Color.White;
            this.btnpauset.Location = new System.Drawing.Point(38, 194);
            this.btnpauset.Name = "btnpauset";
            this.btnpauset.Size = new System.Drawing.Size(137, 58);
            this.btnpauset.TabIndex = 2;
            this.btnpauset.Text = "Pause";
            this.btnpauset.Click += new System.EventHandler(this.btnpauset_Click);
            // 
            // btnresumet
            // 
            this.btnresumet.BorderColor = System.Drawing.Color.Teal;
            this.btnresumet.BorderRadius = 10;
            this.btnresumet.BorderThickness = 5;
            this.btnresumet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresumet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnresumet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnresumet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnresumet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnresumet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnresumet.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresumet.ForeColor = System.Drawing.Color.White;
            this.btnresumet.Location = new System.Drawing.Point(38, 299);
            this.btnresumet.Name = "btnresumet";
            this.btnresumet.Size = new System.Drawing.Size(137, 58);
            this.btnresumet.TabIndex = 3;
            this.btnresumet.Text = "Resume";
            this.btnresumet.Click += new System.EventHandler(this.btnresumet_Click);
            // 
            // btnexitt
            // 
            this.btnexitt.BorderColor = System.Drawing.Color.Teal;
            this.btnexitt.BorderRadius = 10;
            this.btnexitt.BorderThickness = 5;
            this.btnexitt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexitt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexitt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexitt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexitt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexitt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnexitt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitt.ForeColor = System.Drawing.Color.White;
            this.btnexitt.Location = new System.Drawing.Point(38, 401);
            this.btnexitt.Name = "btnexitt";
            this.btnexitt.Size = new System.Drawing.Size(137, 58);
            this.btnexitt.TabIndex = 4;
            this.btnexitt.Text = "Exit";
            this.btnexitt.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 17;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button5.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(12, 9);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(38, 33);
            this.guna2Button5.TabIndex = 5;
            this.guna2Button5.Text = "X";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text to Speech";
            // 
            // textTospeech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.btnexitt);
            this.Controls.Add(this.btnresumet);
            this.Controls.Add(this.btnpauset);
            this.Controls.Add(this.btnspeakt);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "textTospeech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "textTospeech";
            this.Load += new System.EventHandler(this.textTospeech_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnspeakt;
        private Guna.UI2.WinForms.Guna2Button btnpauset;
        private Guna.UI2.WinForms.Guna2Button btnresumet;
        private Guna.UI2.WinForms.Guna2Button btnexitt;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtSpeakt;
    }
}