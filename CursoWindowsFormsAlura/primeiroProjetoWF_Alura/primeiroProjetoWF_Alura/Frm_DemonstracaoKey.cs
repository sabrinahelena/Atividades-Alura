using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroProjetoWF_Alura
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }


        private void Txt_Input_KeyDown(object sender, KeyEventArgs e) //Quando tecla for pressionada na xaida de texto nomeada input
        {//Faça isso
            Txt_Msg.AppendText("\r\n " + "PRESSIONEI UMA TECLA " + e.KeyCode +"\r\n"); //Append, pegar oq foi digitado e escrever essa mensagem.
            Txt_Msg.AppendText("\r\n " + "NOME DA TECLA " + e.KeyData + "\r\n"); //O e.KeyAlgo retorna a tecla.
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower(); //Coloca o e. no texto toLower
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();//Coloca o e. no texto toUpper

        }

        //Portanto, a variável e, armazena os parâmetros. 

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Lbl_Upper.Text = "";
            Lbl_Lower.Text = "";
            Txt_Input.Text = "";
        }
    }
}
