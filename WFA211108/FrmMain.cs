using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA211108
{
    public partial class FrmMain : Form
    {

        public string ConnectionString { private set; get; }

        public FrmMain()
        {
            ConnectionString =
                @"Server = (localdb)\MSSQLLocalDB;" +
                "Database = UniMenes";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var r = new SqlCommand(
                    "SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Varos, Suly, Nem " +
                    "FROM Fajta " +
                    "INNER JOIN Unikornis ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON TulajdonosId = Tenyeszto.Id;",
                    connection).ExecuteReader();

                while(r.Read())
                {
                    dgvMain.Rows.Add(r[0], r[1], r[2], r[3], r[4] + " Kg", 
                        r.GetBoolean(5) ? "Csődör" : "Kanca");
                }
            }
        }
    }
}
