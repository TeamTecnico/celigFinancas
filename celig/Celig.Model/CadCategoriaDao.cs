using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;


namespace Celig.Model
{
    public class CadCategoriaDao
    {
        private DataBase db;

        public CadCategoriaDao()
        {
            db = new DataBase();
        }


        public int InsertCat(Categoria desc)
        {
            int resultado = 0;

            string cmd = "INSERT INTO CATEGORIA (DESCRICAO)" + "VALUES (@descri)";

            try
            {
                db.OpenConn();
                db.addParameter("@descri", desc.Descricao, DbType.String);
                resultado = db.ExecuteNoQuery(cmd);
                db.CloseConn();
                
            }
            catch (Exception)
            {

                throw new Exception("Erro no Banco de Dados");
            }
            return resultado;
        }



        //private List<string> mostrarCb()
        //{

        //    List<string> cadcat = new List<string>();
            
        //    string sql = "SELECT * FROM CATEGORIA";
        //    SQLiteDataReader dr = null;
        //    CadCategoria cad = new CadCategoria();
        //    try
        //    {
        //        db.OpenConn();
                
        //        dr = db.ExecuteReader(sql);
        //        while (dr.Read())
        //        {
        //           cadcat.Add(dr["DESCRICAO"]);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

    }
}
