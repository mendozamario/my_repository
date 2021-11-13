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
    public partial class FrmSession : Form
    {
        Panel PnlMain;
        public FrmSession(Panel mainPanel)
        {
            InitializeComponent();
            PnlMain = mainPanel;
        }
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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAddSession());
        }
    }
}
