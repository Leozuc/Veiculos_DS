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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        // botão que leva pra tela 'caminhão'
        private void btncaminhao_Click(object sender, EventArgs e)
        {
            frmcaminhaocds caminhao = new frmcaminhaocds();
            this.Hide();
            caminhao.Show();

        }

        // botão que leva pra tela 'carro'

        private void btncarro_Click(object sender, EventArgs e)
        {
            frmcarro carro = new frmcarro();
            this.Hide();
            carro.Show();
        }

        // botão que fechará

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
