using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celig.Model;
using System.Data.SQLite;



namespace celig.view
{
    public partial class DespCad : Form
    {
        private DataBase db;
        public DespCad()
        {
            db = new DataBase();
            InitializeComponent();
        }

        //private void DespCad_Load(object sender, EventArgs e)
        //{
        //    mostrarCb();
        //}


       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void DespCad_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoriaCad_Click(object sender, EventArgs e)
        {
            CadCategoria cdC = new CadCategoria();
            cdC.ShowDialog();
        }
    }
}
