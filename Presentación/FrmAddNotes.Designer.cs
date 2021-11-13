
namespace Presentación
{
    partial class FrmAddNotes
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
            this.TxtPatientId = new System.Windows.Forms.TextBox();
            this.LblTypeId = new System.Windows.Forms.Label();
            this.RtbNote = new System.Windows.Forms.RichTextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlControl.SuspendLayout();
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
            this.PnlControl.Size = new System.Drawing.Size(634, 40);
            this.PnlControl.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(60, 19);
            this.LblTitle.TabIndex = 9;
            this.LblTitle.Text = "Add Notes";
            // 
            // TxtPatientId
            // 
            this.TxtPatientId.Enabled = false;
            this.TxtPatientId.Location = new System.Drawing.Point(197, 99);
            this.TxtPatientId.Name = "TxtPatientId";
            this.TxtPatientId.Size = new System.Drawing.Size(322, 20);
            this.TxtPatientId.TabIndex = 37;
            // 
            // LblTypeId
            // 
            this.LblTypeId.AutoSize = true;
            this.LblTypeId.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.LblTypeId.Location = new System.Drawing.Point(105, 100);
            this.LblTypeId.Name = "LblTypeId";
            this.LblTypeId.Size = new System.Drawing.Size(74, 19);
            this.LblTypeId.TabIndex = 36;
            this.LblTypeId.Text = "Patient ID:";
            // 
            // RtbNote
            // 
            this.RtbNote.Location = new System.Drawing.Point(109, 162);
            this.RtbNote.Name = "RtbNote";
            this.RtbNote.Size = new System.Drawing.Size(410, 526);
            this.RtbNote.TabIndex = 38;
            this.RtbNote.Text = "";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnCancel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(90, 746);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 34);
            this.BtnCancel.TabIndex = 40;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnSave.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(456, 746);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 34);
            this.BtnSave.TabIndex = 39;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Image = global::Presentación.Properties.Resources.maximize;
            this.BtnMaximize.Location = new System.Drawing.Point(546, 2);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(35, 35);
            this.BtnMaximize.TabIndex = 8;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Image = global::Presentación.Properties.Resources.minimize;
            this.BtnMinimize.Location = new System.Drawing.Point(505, 2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(35, 35);
            this.BtnMinimize.TabIndex = 7;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::Presentación.Properties.Resources.close_windows;
            this.BtnClose.Location = new System.Drawing.Point(587, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmAddNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.RtbNote);
            this.Controls.Add(this.TxtPatientId);
            this.Controls.Add(this.LblTypeId);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddNotes";
            this.Text = "FrmAddNotes";
            this.PnlControl.ResumeLayout(false);
            this.PnlControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtPatientId;
        private System.Windows.Forms.Label LblTypeId;
        private System.Windows.Forms.RichTextBox RtbNote;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
    }
}