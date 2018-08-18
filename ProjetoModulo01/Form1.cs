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
        private int iSelecionado;

        public Form1()
        {
            iSelecionado = -1;
            InitializeComponent();
            CriarColunas();
        }
        private void CriarColunas()
        {
            lvlNomes.Clear();
            lvlNomes.Columns.Insert(0, "Nome", 230,HorizontalAlignment.Left);
            lvlNomes.Columns.Insert(1, "Idade", 120, HorizontalAlignment.Right);
          
        }


        private void BtnBotao1_Click(object sender, EventArgs e)
        {
            if (iSelecionado > -1)
            {
                lvlNomes.Items[iSelecionado].SubItems[0].Text = txtNome.Text.Trim();
                lvlNomes.Items[iSelecionado].SubItems[1].Text = txtBoxIdade.Text.Trim();
                iSelecionado = -1;
                BtnBotao1.Text = "Cadastrar";
               
                txtNome.Text = String.Empty;
                txtBoxIdade.Text = String.Empty;
                return;
            }
            ListViewItem itmX = lvlNomes.Items.Add(txtNome.Text.Trim());
            itmX.SubItems.Add(new ListViewItem.ListViewSubItem(null, txtBoxIdade.Text.Trim()));
            txtNome.Text = String.Empty;
            txtBoxIdade.Text = String.Empty;
        }
      

        private void Btnbotao2_Click(object sender, EventArgs e)
        {

            txtNome.Text = string.Empty;
            txtBoxIdade.Text = string.Empty;
            lvlNomes.Items.Clear();


        }

        // evento validating para aparecer a mensagem se for digitado apenas dois caracteres
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(txtNome.Text.Trim().Length < 3 )
            {
                MessageBox.Show("Nome Invalido");
                txtNome.Focus();
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
        
        }

        private void txtBoxIdade_Validating(object sender, CancelEventArgs e)
        {
            if(txtBoxIdade.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Idade Invalida");
                txtBoxIdade.Focus();
            }
        }

        private void btnRemoverNome_Click(object sender, EventArgs e)
        {
            if(lvlNomes.SelectedIndices.Count<1)
            {
                MessageBox.Show("Selecione algum item para remover!");
                return;
            }
            int iPosicao = lvlNomes.SelectedIndices[0];
            lvlNomes.Items.RemoveAt(iPosicao);
        }

        private void lvlNomes_DoubleClick(object sender, EventArgs e)
        {
            if (lvlNomes.SelectedIndices.Count < 1) return;
            iSelecionado = lvlNomes.SelectedIndices[0];
            txtNome.Text = lvlNomes.Items[iSelecionado].SubItems[0].Text;
            txtBoxIdade.Text = lvlNomes.Items[iSelecionado].SubItems[1].Text;
            BtnBotao1.Text = "Alterar";
        }
    }   
}
