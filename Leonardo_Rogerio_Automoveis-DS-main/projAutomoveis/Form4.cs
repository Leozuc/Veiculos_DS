using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAutomoveis
{
    public partial class frmcaminhaocds : Form
    {
        // Determinando carro como um objetivo do tipo Carro

        Caminhao caminhao;

        public frmcaminhaocds()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // instanciando de acordo com o preenchimento do usuario

            caminhao = new Caminhao(txtMarca.Text, txtPlaca.Text, txtCor.Text, txtTpCarga.Text, (Convert.ToInt32(txtComb.Text)),
            txtCabine.Text, txtChassi.Text, txtPorte.Text);


            // limpando 

            txtComb.Clear();
            txtPorte.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtTpCarga.Clear();
            txtCabine.Clear();

            txtPorte.Focus();


            // Caixa de mensagem caso o preenchimento seja cadastrado
            MessageBox.Show("Caminhão cadastrado!");

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            // Caixa de mensagem com os dados informados
            MessageBox.Show(caminhao.ApresentarDados());
        }


        // limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComb.Clear();
            txtPorte.Clear();
            txtChassi.Clear();
            txtCor.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtTpCarga.Clear();
            txtCabine.Clear();

            txtPorte.Focus();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

            // voltar
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void frmcaminhaocds_Load(object sender, EventArgs e)
        {

        }
    }
}
