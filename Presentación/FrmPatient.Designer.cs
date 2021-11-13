
namespace Presentación
{
    partial class FrmPatient
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
            this.LblFilter = new System.Windows.Forms.Label();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvPatients = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilter.Location = new System.Drawing.Point(114, 82);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(65, 29);
            this.LblFilter.TabIndex = 0;
            this.LblFilter.Text = "Filter:";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(210, 91);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(600, 20);
            this.TxtFilter.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnSearch.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(841, 84);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 34);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // DgvPatients
            // 
            this.DgvPatients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPatients.Location = new System.Drawing.Point(29, 181);
            this.DgvPatients.Name = "DgvPatients";
            this.DgvPatients.Size = new System.Drawing.Size(974, 170);
            this.DgvPatients.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnAdd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(658, 412);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 34);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnView.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(292, 412);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 34);
            this.BtnView.TabIndex = 5;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = false;
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 540);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvPatients);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.LblFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFilter;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvPatients;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnView;
    }
}