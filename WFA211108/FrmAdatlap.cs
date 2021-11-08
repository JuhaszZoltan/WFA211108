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
    public partial class FrmAdatlap : Form
    {
        public string ConnectionString { get; private set; }
        public int SelFajtaID { get; private set; } = 0;
        public int SelTenyesztoID { get; private set; } = 0;


        public FrmAdatlap(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmAdatlap_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand("SELECT Nev FROM Tenyeszto", conn)
                    .ExecuteReader();
                while (r.Read()) cbTulajdonosok.Items.Add(r[0]);
                r.Close();
                r = new SqlCommand("SELECT Nev From Fajta", conn)
                    .ExecuteReader();
                while (r.Read()) cbFajtak.Items.Add(r[0]);
            }

            cbTulajdonosok.SelectedIndex = 0;
            cbFajtak.SelectedIndex = 0;
        }
        private void CbFajtak_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    $"SELECT Id FROM Fajta " +
                    $"WHERE Nev = '{cbFajtak.Text}';", conn)
                    .ExecuteReader();
                r.Read();
                SelFajtaID = r.GetInt32(0);
            }

            switch (cbFajtak.Text)
            {
                case "ninja": 
                    pbFajta.Image = Properties.Resources.ninja;
                    break;
                case "robot":
                    pbFajta.Image = Properties.Resources.robot;
                    break;
                case "dapper":
                    pbFajta.Image = Properties.Resources.dapper;
                    break;
                case "nyan":
                    pbFajta.Image = Properties.Resources.nyan;
                    break;
                case "zombie":
                    pbFajta.Image = Properties.Resources.zombie;
                    break;
                case "hipster":
                    pbFajta.Image = Properties.Resources.hipster;
                    break;
            }
        }
        private void CbTulajdonosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand(
                    $"SELECT Id FROM Tenyeszto " +
                    $"WHERE Nev = '{cbTulajdonosok.Text}';", conn)
                    .ExecuteReader();
                r.Read();
                SelTenyesztoID = r.GetInt32(0);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                new SqlCommand(
                    "INSERT INTO Unikornis VALUES " +
                    $"({SelTenyesztoID}, {SelFajtaID}, {nudSuly.Value}, {(rbCsodor.Checked ? 1 : 0)});",
                    conn).ExecuteNonQuery();
            }
            this.Dispose();
        }
    }
}
