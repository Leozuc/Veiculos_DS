using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAutomoveis
{
    public partial class frmcarro : Form
    {

        // Determinando carro como um objetivo do tipo Carro
        Carro carro;
        public frmcarro()
        {
            InitializeComponent();
        }

        // botão que limpará 
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComb.Clear();
            txtCapMala.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtNumPorta.Clear();
            txtTpCarro.Clear();
            txtCapMala.Clear();
        }

        // botão que voltará
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            

            // instanciando de acordo com o preenchimento do usuario
            carro = new Carro(txtMarca.Text, txtPlaca.Text, txtCor.Text, txtTpCarro.Text,(Convert.ToInt32(txtComb.Text)),
            txtCapMala.Text, (Convert.ToInt32(txtNumPorta.Text)), txtChassi.Text);


            // limpando 
            txtComb.Clear();
            txtCapMala.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtNumPorta.Clear();
            txtTpCarro.Clear();
            txtCapMala.Clear();

            MessageBox.Show("Carro cadastrado!");

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.ApresentarDados());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmcarro_Load(object sender, EventArgs e)
        {

        }
    }
}
