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
    public partial class TelaCadastroUser : Form
    {
        public TelaCadastroUser()
        {
            InitializeComponent();
        }





        private void BtnTelaCadastrarUser_Click(object sender, EventArgs e)
        {
            int resultado;
            ControlerLogin log = new ControlerLogin();
            CadastroUser cadUser = new CadastroUser();
            cadUser.userName = TxtNomeUsuarioCadastro.Text;
            cadUser.password = TxtSenhaUsuarioCadastro.Text;

            if ((TxtConfirmarSenhaCadastro.Text.Length != 0) && (TxtNomeUsuarioCadastro.Text.Length != 0) && (TxtSenhaUsuarioCadastro.Text.Length != 0))
            {
                if (TxtSenhaUsuarioCadastro.Text == TxtConfirmarSenhaCadastro.Text)
                {
                    resultado = log.CadastroUser(cadUser);

                    if (resultado!=0)
                    {
                        MessageBox.Show("Cadastro bem sucedido");
                    }
                }
                else
                {
                    MessageBox.Show("As senhas devem ser iguais");
                }
               
            }
            else
            {
                MessageBox.Show("Você deve preencher todos os campos");
            }
	         

           

        }
    }
}
