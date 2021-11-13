
namespace Presentación
{
    partial class FrmBase
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
            this.PnlControl = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlMainBar = new System.Windows.Forms.Panel();
            this.PnlTilteBar = new System.Windows.Forms.Panel();
            this.LblType = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAppName = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.BtnSession = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlControl.SuspendLayout();
            this.PnlMainBar.SuspendLayout();
            this.PnlTilteBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlControl
            // 
            this.PnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.PnlControl.Controls.Add(this.LblTitle);
            this.PnlControl.Controls.Add(this.BtnMaximize);
            this.PnlControl.Controls.Add(this.BtnMinimize);
            this.PnlControl.Controls.Add(this.BtnClose);
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(1200, 40);
            this.PnlControl.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(28, 8);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(35, 19);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "Main";
            // 
            // PnlMainBar
            // 
            this.PnlMainBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.PnlMainBar.Controls.Add(this.BtnSettings);
            this.PnlMainBar.Controls.Add(this.BtnDoctor);
            this.PnlMainBar.Controls.Add(this.BtnSession);
            this.PnlMainBar.Controls.Add(this.BtnPatient);
            this.PnlMainBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainBar.Location = new System.Drawing.Point(0, 40);
            this.PnlMainBar.Name = "PnlMainBar";
            this.PnlMainBar.Size = new System.Drawing.Size(163, 660);
            this.PnlMainBar.TabIndex = 1;
            // 
            // PnlTilteBar
            // 
            this.PnlTilteBar.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlTilteBar.Controls.Add(this.LblType);
            this.PnlTilteBar.Controls.Add(this.LblName);
            this.PnlTilteBar.Controls.Add(this.LblAppName);
            this.PnlTilteBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTilteBar.Location = new System.Drawing.Point(163, 40);
            this.PnlTilteBar.Name = "PnlTilteBar";
            this.PnlTilteBar.Size = new System.Drawing.Size(1037, 120);
            this.PnlTilteBar.TabIndex = 2;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(875, 62);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(127, 23);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Administrator";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.LblName.Location = new System.Drawing.Point(891, 33);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(95, 29);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Mendoza";
            // 
            // LblAppName
            // 
            this.LblAppName.AutoSize = true;
            this.LblAppName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.LblAppName.Location = new System.Drawing.Point(50, 42);
            this.LblAppName.Name = "LblAppName";
            this.LblAppName.Size = new System.Drawing.Size(182, 42);
            this.LblAppName.TabIndex = 0;
            this.LblAppName.Text = "Clinic Planner";
            this.LblAppName.Click += new System.EventHandler(this.LblAppName_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMain.Location = new System.Drawing.Point(163, 160);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1037, 540);
            this.PnlMain.TabIndex = 3;
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Image = global::Presentación.Properties.Resources.settings;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSettings.Location = new System.Drawing.Point(48, 535);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(75, 86);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.FlatAppearance.BorderSize = 0;
            this.BtnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoctor.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.ForeColor = System.Drawing.Color.White;
            this.BtnDoctor.Image = global::Presentación.Properties.Resources.doctor;
            this.BtnDoctor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDoctor.Location = new System.Drawing.Point(48, 398);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(75, 86);
            this.BtnDoctor.TabIndex = 2;
            this.BtnDoctor.Text = "Doctor";
            this.BtnDoctor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDoctor.UseVisualStyleBackColor = true;
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnSession
            // 
            this.BtnSession.FlatAppearance.BorderSize = 0;
            this.BtnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSession.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSession.ForeColor = System.Drawing.Color.White;
            this.BtnSession.Image = global::Presentación.Properties.Resources.session;
            this.BtnSession.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSession.Location = new System.Drawing.Point(48, 261);
            this.BtnSession.Name = "BtnSession";
            this.BtnSession.Size = new System.Drawing.Size(75, 86);
            this.BtnSession.TabIndex = 1;
            this.BtnSession.Text = "Session";
            this.BtnSession.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSession.UseVisualStyleBackColor = true;
            this.BtnSession.Click += new System.EventHandler(this.BtnSession_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatient.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatient.ForeColor = System.Drawing.Color.White;
            this.BtnPatient.Image = global::Presentación.Properties.Resources.patient;
            this.BtnPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPatient.Location = new System.Drawing.Point(48, 124);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(75, 86);
            this.BtnPatient.TabIndex = 0;
            this.BtnPatient.Text = "Patient";
            this.BtnPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPatient.UseVisualStyleBackColor = true;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Image = global::Presentación.Properties.Resources.maximize;
            this.BtnMaximize.Location = new System.Drawing.Point(1112, 2);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(35, 35);
            this.BtnMaximize.TabIndex = 5;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Image = global::Presentación.Properties.Resources.minimize;
            this.BtnMinimize.Location = new System.Drawing.Point(1071, 2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(35, 35);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::Presentación.Properties.Resources.close_windows;
            this.BtnClose.Location = new System.Drawing.Point(1153, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlTilteBar);
            this.Controls.Add(this.PnlMainBar);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.PnlControl.ResumeLayout(false);
            this.PnlControl.PerformLayout();
            this.PnlMainBar.ResumeLayout(false);
            this.PnlTilteBar.ResumeLayout(false);
            this.PnlTilteBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Panel PnlMainBar;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.Button BtnSession;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Panel PnlTilteBar;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAppName;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel PnlMain;
    }
}