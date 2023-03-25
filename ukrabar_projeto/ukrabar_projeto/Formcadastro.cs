using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukrabar_projeto
{
    public partial class Formcadastro : Form
    {
        public Formcadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void entrarcliente_Click(object sender, EventArgs e)
        {
            Formlogin cadastro = new Formlogin();
            cadastro.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formprodutos_adm cadastro = new Formprodutos_adm();
            cadastro.ShowDialog();
            this.Close();
        }
    }
}
