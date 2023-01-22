using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Compara, Se o método showdialog do componente openfiledialog tem resultado verdadeiro do botão ok do diálogo
            // DialogResult é um valor especial que indica o que acontece em uma caixa de dialogo, o componente openFileDialog1
            // pode resultar entre o usuário escolher entre OK e Cancelar.Portanto, seu método ShowDialog() retorna DialogResult.OK ou DialogResult.Cancel
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);

            }

           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //LImpa a imagem
            //pictureBox1 é um componente e Image é uma propriedade
            pictureBox1.Image = null;
   
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Define a cor de fundo,do componente pictureBox1
                pictureBox1.BackColor = colorDialog1.Color;

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar o formulário
            this.Close();   //Close() Método
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se componente checkBox estiver com sua propriedade Checked com estado Verdadeiro
            if (checkBox1.Checked)
            {
                //Altera a propriedade 'sizeMode' do componente 'pictureBox' para modo esticar a imagem
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                //Altera a propriedade 'sizeMode' do componente 'pictureBox' para modo normal
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
 
    }
}
