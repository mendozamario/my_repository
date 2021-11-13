using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            OpenChildForm(new FrmMain());
        }

        Color primaryColor = Color.FromArgb(233, 128, 37);
        Color baseColor = Color.White;

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(childForm);
            PnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LblAppName_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMain());
        }

        private void ChangeColors(Button selectedButton, string ruta)
        {
            BtnPatient.ForeColor = baseColor;
            BtnDoctor.ForeColor = baseColor;
            BtnSession.ForeColor = baseColor;
            BtnSettings.ForeColor = baseColor;
            BtnPatient.Image = Image.FromFile(@"D:\code\Project_x\icons\patient.png");
            BtnDoctor.Image = Image.FromFile(@"D:\code\Project_x\icons\doctor.png");
            BtnSession.Image = Image.FromFile(@"D:\code\Project_x\icons\session.png");
            BtnSettings.Image = Image.FromFile(@"D:\code\Project_x\icons\settings.png");

            selectedButton.ForeColor = primaryColor;
            selectedButton.Image = Image.FromFile(ruta);
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            ChangeColors(BtnPatient, @"D:\code\Project_x\icons\patient_selected.png");
            OpenChildForm(new FrmPatient(PnlMain));
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            ChangeColors(BtnDoctor, @"D:\code\Project_x\icons\doctor_selected.png");
            OpenChildForm(new FrmDoctor(PnlMain));
        }

        private void BtnSession_Click(object sender, EventArgs e)
        {
            ChangeColors(BtnSession, @"D:\code\Project_x\icons\session_selected.png");
            OpenChildForm(new FrmSession(PnlMain));
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            ChangeColors(BtnSettings, @"D:\code\Project_x\icons\settings_selected.png");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
