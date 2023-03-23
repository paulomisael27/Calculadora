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
    public partial class CalSec : Form
    {
        public CalSec()
        {
            InitializeComponent();
        }

        private void ResultadoTotalSec()
        {
            try
            {
                txtResultadoM2.Text =
                (Convert.ToDecimal(txtTotal1.Text)
                +
                Convert.ToDecimal(txtTotal2.Text)
                +
                Convert.ToDecimal(txtTotal3.Text)
                +
                Convert.ToDecimal(txtTotal4.Text)
                +
                Convert.ToDecimal(txtTotal5.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalM2Sec1()
        {
            try
            {
                txtTotal1.Text =
                (Convert.ToDecimal(txtLargura1.Text)
                *
                Convert.ToDecimal(txtAltura1.Text)
                *
                Convert.ToDecimal(txtQuantidade1.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalM2Sec2()
        {
            try
            {
                txtTotal2.Text =
                (Convert.ToDecimal(txtLargura2.Text)
                *
                Convert.ToDecimal(txtAltura2.Text)
                *
                Convert.ToDecimal(txtQuantidade2.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalM2Sec3()
        {
            try
            {
                txtTotal3.Text =
                (Convert.ToDecimal(txtLargura3.Text)
                *
                Convert.ToDecimal(txtAltura3.Text)
                *
                Convert.ToDecimal(txtQuantidade3.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalM2Sec4()
        {
            try
            {
                txtTotal4.Text =
                (Convert.ToDecimal(txtLargura4.Text)
                *
                Convert.ToDecimal(txtAltura4.Text)
                *
                Convert.ToDecimal(txtQuantidade4.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalM2Sec5()
        {
            try
            {
                txtTotal5.Text =
                (Convert.ToDecimal(txtLargura5.Text)
                *
                Convert.ToDecimal(txtAltura5.Text)
                *
                Convert.ToDecimal(txtQuantidade5.Text)).ToString();
            }
            catch
            {

            }
        }

        private void btnCopiar2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtResultadoM2.Text);
            }
            catch
            {
                MessageBox.Show("Está vazio", "Info");
            }  
        }

        private void btnVoltarForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            txtLargura2.Visible = true;
            txtAltura2.Visible = true;
            txtQuantidade2.Visible = true;
            btnAdd2.Visible = true;
            LabelSC2.Visible = true;
            LabelS2.Visible = true;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            txtLargura3.Visible = true;
            txtAltura3.Visible = true;
            txtQuantidade3.Visible = true;
            btnAdd3.Visible = true;
            LabelSC3.Visible = true;
            LabelS3.Visible = true;
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            txtLargura4.Visible = true;
            txtAltura4.Visible = true;
            txtQuantidade4.Visible = true;
            btnAdd4.Visible = true;
            LabelSC4.Visible = true;
            LabelS4.Visible = true;
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            txtLargura5.Visible = true;
            txtAltura5.Visible = true;
            txtQuantidade5.Visible = true;
            LabelSC5.Visible = true;
            LabelS5.Visible = true;
        }

        private void txtLargura1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtAltura1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtTotal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtLargura2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtAltura2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtTotal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtLargura3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtAltura3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtTotal3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtLargura4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtAltura4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtTotal4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtLargura5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtAltura5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtTotal5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtLargura1_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec1();
        }

        private void txtAltura1_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec1();
        }

        private void txtQuantidade1_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec1();
        }

        private void txtLargura2_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec2();
        }

        private void txtAltura2_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec2();
        }

        private void txtQuantidade2_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec2();
        }

        private void txtLargura3_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec3();
        }

        private void txtAltura3_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec3();
        }

        private void txtQuantidade3_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec3();
        }

        private void txtLargura4_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec4();
        }

        private void txtAltura4_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec4();
        }

        private void txtQuantidade4_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec4();
        }

        private void txtLargura5_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec5();
        }

        private void txtAltura5_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec5();
        }

        private void txtQuantidade5_TextChanged(object sender, EventArgs e)
        {
            CalM2Sec5();
        }

        private void txtTotal1_TextChanged(object sender, EventArgs e)
        {
            ResultadoTotalSec();
        }

        private void txtTotal2_TextChanged(object sender, EventArgs e)
        {
            ResultadoTotalSec();
        }

        private void txtTotal3_TextChanged(object sender, EventArgs e)
        {
            ResultadoTotalSec();
        }

        private void txtTotal4_TextChanged(object sender, EventArgs e)
        {
            ResultadoTotalSec();
        }

        private void txtTotal5_TextChanged(object sender, EventArgs e)
        {
            ResultadoTotalSec();
        }

        private void btnEsconderTextBoxes_Click(object sender, EventArgs e)
        {
            LabelSC5.Visible = false;
            LabelS5.Visible = false;
            LabelSC4.Visible = false;
            LabelS4.Visible = false;
            LabelSC3.Visible = false;
            LabelS3.Visible = false;
            LabelSC2.Visible = false;
            LabelS2.Visible = false;
            txtLargura2.Visible = false;
            txtAltura2.Visible = false;
            txtQuantidade2.Visible = false;
            btnAdd2.Visible = false;
            btnAdd3.Visible = false;
            btnAdd4.Visible = false;
            txtLargura3.Visible = false;
            txtAltura3.Visible = false;
            txtQuantidade3.Visible = false;
            txtLargura4.Visible = false;
            txtAltura4.Visible = false;
            txtQuantidade4.Visible = false;
            txtLargura5.Visible = false;
            txtAltura5.Visible = false;
            txtQuantidade5.Visible = false;
        }

        private void txtResultadoM2Sec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagarDados_Click(object sender, EventArgs e)
        {
            txtResultadoM2.Clear();
        }
    }
}