using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_3._2
{
    public partial class frmTugasTiga3 : Form
    {
        public frmTugasTiga3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }     

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = String.Format("Halo {0}", nama);
            txtPesan2.Text = String.Format("Pendidikan anda {0} ya?", pendidikan);
            txtPesan3.Text = String.Format("Anda Seorang {0}, Hebat!!!", pekerjaan);
        }
    }
}
