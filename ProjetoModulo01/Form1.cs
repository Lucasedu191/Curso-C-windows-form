using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo01
{
    public partial class Form1 : Form
    {
        int iselecionado;

        public Form1()
        {
            
            InitializeComponent();
            iselecionado = -1;
        } 
        private void BtnBotao1_Click(object sender, EventArgs e)
        {
            if (iselecionado > -1)
            {
                LsblistaNomes.Items[iselecionado] = textBox1.Text;
                ordenar();
                Btnbotao2_Click(Btnbotao2, new EventArgs());
                iselecionado = -1;
                BtnBotao1.Text = "Cadastrar";
                return;
            }
            LsblistaNomes.Items.Add(textBox1.Text);
            ordenar();
            //chama o evento click de limpar o text box
            Btnbotao2_Click(Btnbotao2, new EventArgs());

        }
        //deixando ordenado para que os nomes saiam em ordem alfabetica
        private void ordenar ()
        {
            ListBox.ObjectCollection lista = LsblistaNomes.Items;
            List<string> listaString = new List<string>();
            foreach (var item in lista)
            {
                listaString.Add(item.ToString());
            }
            listaString = (from s in listaString select s).OrderBy(x => x).ToList();
            LsblistaNomes.Items.Clear();
            foreach (var item in listaString)
            {
                LsblistaNomes.Items.Add(item);
            }
        }
        // limpa a label e limpa o textbox
        private void Btnbotao2_Click(object sender, EventArgs e)
        {

            textBox1.Text = string.Empty;
        }

        // evento validating para aparecer a mensagem se for digitado apenas dois caracteres
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text.Length == null )
            {
                MessageBox.Show("Nome Invalido");
            }
        }
          
        // coloca a tecla enter como evento no text box e não precisa clicar no botão
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnBotao1_Click(BtnBotao1, new EventArgs());
            }
        }

        private void LsblistaNomes_DoubleClick(object sender, EventArgs e)
        {
            iselecionado = LsblistaNomes.SelectedIndex;
            textBox1.Text = LsblistaNomes.Items[iselecionado].ToString();
            BtnBotao1.Text = "Alterar";
        }
    }   
}
