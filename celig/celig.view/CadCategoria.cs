using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celig.Controller;
using Celig.Model;

namespace celig.view
{
    public partial class CadCategoria : Form
    {
        public CadCategoria()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

           

            

            if (txtCat.Text.Length == 0)
            {
                MessageBox.Show("Campo deve ser preenchido");
            }
            else
            {
                Categoria cat = new Categoria();

                cat.Descricao = txtCat.Text;

                
                int resultado = ControlerDespesas.CadCat(cat);
                if (resultado != 0)
                {
                    MessageBox.Show("Inclusão bem sucedida");
                }
                else
                {
                    MessageBox.Show("Inclusão mal sucedida ");
                }
            }

        }
    }
}
