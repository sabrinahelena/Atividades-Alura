using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UsandoMasaras
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaskedBox.Mask = "$ 00.00";
            MaskedBox.Text = "";
            MaskedBox.Focus();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            MaskedBox.UseSystemPasswordChar = false;
            MaskedBox.Mask = "00:00";
            MaskedBox.Text = "";
            MaskedBox.Focus();

        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            MaskedBox.UseSystemPasswordChar = false;
            MaskedBox.Mask = "00000-000";     
            MaskedBox.Text = "";
            MaskedBox.Focus();
        }

        private void Btn_Conteudo_Click(object sender, EventArgs e)
        {
            MaskedBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = MaskedBox.Text;
        }

        private void Frm_Mascara_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            MaskedBox.UseSystemPasswordChar = false;
            MaskedBox.Mask = "00/00/0000";
            MaskedBox.Text = "";
            MaskedBox.Focus();
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            MaskedBox.UseSystemPasswordChar = true;
            MaskedBox.Mask = "000000";
            MaskedBox.Text = "";
            MaskedBox.Focus();

        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            MaskedBox.UseSystemPasswordChar = false;
            MaskedBox.Mask = "(00) 0 0000-0000";
            MaskedBox.Text = "";
            MaskedBox.Focus();

        }
    }
}
