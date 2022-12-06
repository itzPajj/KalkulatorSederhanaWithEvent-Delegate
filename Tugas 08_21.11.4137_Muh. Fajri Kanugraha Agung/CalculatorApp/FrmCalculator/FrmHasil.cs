using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCalculator
{
    public partial class frmHasil : Form
    {
        public frmHasil()
        {
            InitializeComponent();
        }

        private void proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
        {
            listBox1.Items.Add(
                String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
                );
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmCalculator formCalculator = new FrmCalculator();
            formCalculator.prosesEvent += proses;
            formCalculator.ShowDialog();
        }
    }
}
