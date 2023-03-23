using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Automatica
{
    public partial class CalcHome : Form
    {
        public CalcHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalSec OutroForm = new CalSec();
            OutroForm.ShowDialog();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em caso de dúvida ligar para o ramal 4030 - Paulo/TI", "Janela de ajuda");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Sobre _sobre = new Sobre();
            _sobre.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculoM2()
        {
            try
            {
                txtResultadoM1.Text =
                (Convert.ToDecimal(txtLargura.Text)
                *
                Convert.ToDecimal(txtAltura.Text)
                *
                Convert.ToDecimal(txtQuantidade.Text)).ToString();
            }
            catch
            {

            }
        }

        private void txtLargura_TextChanged(object sender, EventArgs e)
        {
            CalculoM2();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            CalculoM2();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalculoM2();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtResultadoM1.Text);
            }
            catch
            {
                MessageBox.Show("Está vazio", "Info");
            }
        }

        private void txtResultadoM1_Leave(object sender, EventArgs e)
        {

        }

        private void txtResultadoM1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLargura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void lblResultadoM1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultadoM1.Clear();
            ToolTip tpApagar = new ToolTip();

            tpApagar.AutoPopDelay = 5000;
            tpApagar.InitialDelay = 1000;
            tpApagar.ReshowDelay = 500;

            tpApagar.ShowAlways = true;

            tpApagar.SetToolTip(this.button1, "Apagar resultado");
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dESENVOLVIDOPORMARCOSOTÍLIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CalcHome_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfAfUiTmxcQDZqwHqVUBVaXahNJQsm0HK_VBh8ku1jZyMmFug/viewform");
        }
    }
}