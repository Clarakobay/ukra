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
    public partial class Formprodutos_adm : Form
    {
        public Formprodutos_adm()
        {
            InitializeComponent();
        }

        private void Formprodutos_adm_Load(object sender, EventArgs e)
        {
          
            
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form_sobremesa sobremesa= new Form_sobremesa();
            sobremesa.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formcadastro cadastro = new Formcadastro();
            cadastro.ShowDialog();
            this.Close();
        }
    }
}
