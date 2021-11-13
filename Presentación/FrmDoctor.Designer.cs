
namespace Presentación
{
    partial class FrmDoctor
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
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DgvDoctors = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.LblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnView.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(294, 413);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 34);
            this.BtnView.TabIndex = 11;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnAdd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(660, 413);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 34);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgvDoctors
            // 
            this.DgvDoctors.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoctors.Location = new System.Drawing.Point(31, 182);
            this.DgvDoctors.Name = "DgvDoctors";
            this.DgvDoctors.Size = new System.Drawing.Size(974, 170);
            this.DgvDoctors.TabIndex = 9;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(128)))), ((int)(((byte)(37)))));
            this.BtnSearch.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(843, 85);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 34);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(212, 92);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(600, 20);
            this.TxtFilter.TabIndex = 7;
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilter.Location = new System.Drawing.Point(116, 83);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(65, 29);
            this.LblFilter.TabIndex = 6;
            this.LblFilter.Text = "Filter:";
            // 
            // FrmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 540);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvDoctors);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.LblFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoctor";
            this.Text = "FrmDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DgvDoctors;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.Label LblFilter;
    }
}