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
    public partial class FrmViewSession : Form
    {
        public FrmViewSession()
        {
            InitializeComponent();
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            new FrmAddNotes().Show();
        }

        private void BtnAddDiagnosis_Click(object sender, EventArgs e)
        {
            new FrmAddDiagnosis().Show();
        }
    }
}
