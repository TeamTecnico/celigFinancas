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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            ControlerLogin clog = new ControlerLogin();

            log.userName = TxtNome.Text;
            log.password = TxtSenha.Text;

            clog.Acessar(log);

            if ((TxtNome.Text.Length != 0) || (TxtSenha.Text.Length != 0))
            {
                if (log.validacao == true)
                {
                    teste tst = new teste();
                    tst.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha não existem");
                }
            }
            else
            {
                MessageBox.Show("Complete todos os campos");
            }
        }
    }
}
