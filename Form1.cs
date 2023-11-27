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

namespace OBS_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "obsDataSet.selectAllBezirk". Sie können sie bei Bedarf verschieben oder entfernen.
            this.selectAllBezirkTableAdapter.Fill(this.obsDataSet.selectAllBezirk);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "obsDataSet.selectAllOrt". Sie können sie bei Bedarf verschieben oder entfernen.
            this.selectAllOrtTableAdapter.Fill(this.obsDataSet.selectAllOrt);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("insertOrt", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@inOID", SqlDbType.Int).Value = Int32.Parse(txtOID.Text);
            cmd.Parameters.Add("@inOName", SqlDbType.VarChar).Value = txtOName.Text;
            cmd.Parameters.Add("@inOPLZ", SqlDbType.VarChar).Value = txtOPLZ.Text;
            cmd.Parameters.Add("@inOEZAHL", SqlDbType.Int).Value = Int32.Parse(txtOEZahl.Text);


            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            // TODO: Diese Codezeile lädt Daten in die Tabelle "obsDataSet.selectAllOrt". Sie können sie bei Bedarf verschieben oder entfernen.
            this.selectAllOrtTableAdapter.Fill(this.obsDataSet.selectAllOrt);

        }

        private void btn_delete_ort_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("deleteFromOrt", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@inOID", SqlDbType.Int).Value = lstID.SelectedValue.ToString();


            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();



            // TODO: Diese Codezeile lädt Daten in die Tabelle "obsDataSet.selectAllOrt". Sie können sie bei Bedarf verschieben oder entfernen.
            this.selectAllOrtTableAdapter.Fill(this.obsDataSet.selectAllOrt);
        }

        private void btnInsertBezirk_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("insertBezirk", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@inBID", SqlDbType.Int).Value = Int32.Parse(txtBID.Text);
            cmd.Parameters.Add("@inBName", SqlDbType.VarChar).Value = txtBName.Text;
            cmd.Parameters.Add("@inBPLZ", SqlDbType.VarChar).Value = txtBPLZ.Text;
            cmd.Parameters.Add("@inBEZAHL", SqlDbType.Int).Value = Int32.Parse(txtBEZahl.Text);


            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            // TODO: Diese Codezeile lädt Daten in die Tabelle "obsDataSet.selectAllOrt". Sie können sie bei Bedarf verschieben oder entfernen.
            this.selectAllOrtTableAdapter.Fill(this.obsDataSet.selectAllOrt);

        }
    }
}
