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
    public partial class FrmCalculator : Form
    {
        public delegate void Proses(int nilaiA,int nilaiB, string operasi, string operasiLabel, float hasil);

        public event Proses prosesEvent;


        public FrmCalculator()
        {
            InitializeComponent();
            CalculatorInit();
        }

        private void CalculatorInit()
        {
            cmbOperasi.Items.Clear();
            cmbOperasi.Items.Add("Penjumlahan");
            cmbOperasi.Items.Add("Pengurangan");
            cmbOperasi.Items.Add("Perkalian");
            cmbOperasi.Items.Add("Pembagian");
            cmbOperasi.SelectedIndex = 0;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(txtNilaiA.Text);
            int nilaiB = int.Parse(txtNilaiB.Text);
            string operasi = "";
            string operasiLabel = "";
            float hasil = 0;
            switch (cmbOperasi.SelectedIndex)
            {
                //penjumlahan
                case 0:
                    hasil = CalculatorApp.Calculator.Penjumlahan(nilaiA, nilaiB);
                    operasiLabel = "Penjumlahan";
                    operasi = "+";
                    break;
                //pengurangan
                case 1:
                    hasil = CalculatorApp.Calculator.Pengurangan(nilaiA, nilaiB);
                    operasiLabel = "Pengurangan";
                    operasi = "-";
                    break;
                //perkalian
                case 2:
                    hasil = CalculatorApp.Calculator.Perkalian(nilaiA, nilaiB);
                    operasiLabel = "Perkalian";
                    operasi = "x";
                    break;
                //pembagian
                case 3:
                    hasil = CalculatorApp.Calculator.Pembagian(nilaiA, nilaiB);
                    operasiLabel = "Pembagian";
                    operasi = "/";
                    break;
            }
            prosesEvent(nilaiA, nilaiB, operasi, operasiLabel, hasil);
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
