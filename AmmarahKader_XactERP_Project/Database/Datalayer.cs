using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmarahKader_XactERP_Project.Database
{
    public class Datalayer
    {
        PgSqlCommand cmd_;
        PgSqlConnection conn_;
        PgSqlDataAdapter adptr_;
        PgSqlDataReader reader_;
        DataTable dtable_;
        DataSet dset_;

        public string getMessage { get; set; }

        public Datalayer()
        {
            string cs = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=AM_Enterprise;Integrated Security=True\" providerName=\"System.Data.SqlClient";
            conn_= new PgSqlConnection(cs);
            cmd_ = new PgSqlCommand();
            dtable_ = new DataTable();
            adptr_ = new PgSqlDataAdapter();
            dset_= new DataSet();

        }

        public bool connect()
        {
            try
            {
                conn_.Open();
                getMessage = "successfully connected";
                return true;
            }
            catch (Exception e)
            {
                getMessage = "connection error" + e.Message;
                return false;
            }
        }
        public bool disconnect()
        {
            try
            {
                conn_.Clone();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        //public void fillcombobox(string qry, ComboBox cmd)
        //{
        //    int i = 0;
        //    List<string> list = new List<string>();
        //    getSingleValueAsArraybyIndex(qry, out 1st, 0); 
        //}

        private void getSingleValueAsArraybyIndex(string qry, out int v1, object st, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
