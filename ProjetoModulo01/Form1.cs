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


        public Form1()
        {
            
            InitializeComponent();
  
        } 
        private void BtnBotao1_Click(object sender, EventArgs e)
        {
            cmbNomes.Items.Add(textBox1.Text);
        }
      

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

        private void cmbNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbNomes.SelectedItem.ToString());
        }
    }   
}
