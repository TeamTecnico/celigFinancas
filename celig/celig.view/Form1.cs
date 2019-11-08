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

        public static string User;

       

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
                    TelaPrincipal telaPrincipal = new TelaPrincipal();
                    telaPrincipal.Show();
                    this.Visible = this.Enabled = false;
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

            User = TxtNome.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LinkCadUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             TelaCadastroUser tela = new TelaCadastroUser();
             tela.Show();
        }
    }
    }

