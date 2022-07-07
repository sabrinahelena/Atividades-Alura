using System;
using System.Windows.Forms;
using conversorDeMoedas.Entities;

namespace conversorDeMoedas
{
    public partial class Frm_ConversorDeMoeda : Form
    {
        public Frm_ConversorDeMoeda()
        {
            InitializeComponent();
        }

        public void btn_DeReal_Click(object sender, EventArgs e)
        {
            Teste menu = new Teste();
            decimal valor = decimal.Parse(mskd_Valor.Text);
           

        }
    }
}
