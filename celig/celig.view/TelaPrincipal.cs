using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celig.view
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            OcultarInicioSubMenus();     
        }
      

       
        
            
        


        private void OcultarInicioSubMenus()
        {
            PnSubMenuContas.Visible = false; //começa ocultando os SubMenus
            PnSubMenuAlertas.Visible = false;
            PnSubMenuCategorias.Visible = false;

        }

        public void VerificarProp()
        {
            if (PnSubMenuContas.Visible == true)
                PnSubMenuContas.Visible = false;

            if (PnSubMenuAlertas.Visible == true)
                PnSubMenuContas.Visible = false;

            if (PnSubMenuCategorias.Visible == true)
                PnSubMenuContas.Visible = false;
        }



        private void MostrarSubMenus(Panel subMenu)
        {
            if (subMenu.Visible== false)
            {
                VerificarProp();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }



        #region Conta
        
        private void btnContas_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnSubMenuContas);
        }


       /////////////////buttons Conta//////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            //codigo....
            
            AbrirFormFilho(new DespCad());
            VerificarProp();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //codigo....

            VerificarProp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //codigo....

            VerificarProp();
        }


        #endregion   //buttons Conta




        #region Alertas

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnSubMenuAlertas);
        }

        /////////////////buttons Alertas//////////////////////////
        private void button7_Click(object sender, EventArgs e)
        {
            //codigo....

            VerificarProp();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //codigo....

            VerificarProp();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //codigo....

            VerificarProp();
        }




        #endregion




        #region Categorias
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            MostrarSubMenus(PnSubMenuCategorias);
        }

        /////////////////buttons Conta//////////////////////////
        private void button9_Click(object sender, EventArgs e)
        {
            //codigo....

            VerificarProp();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //codigo....

            VerificarProp();
        }
        #endregion




        private void PnRodape_Paint(object sender, PaintEventArgs e)
        {
            LbNomeUser.Text = "Bem Vindo  " + Form1.User;
        }

        // metodo para colocar um novo forms no panel central
        private Form formAtivo = null;

        public void AbrirFormFilho(Form formFilho)
        {
            if (formAtivo!=null)
                formAtivo.Close();
                formAtivo = formFilho;
                formFilho.TopLevel = false;
                formFilho.FormBorderStyle = FormBorderStyle.None;
                formFilho.Dock = DockStyle.Fill;
                PnPrincipal.Controls.Add(formFilho);
                PnPrincipal.Tag = formFilho;
                formFilho.BringToFront(); // coloca o form na frente do panel
                formFilho.Show();
            

        }



    }
}
