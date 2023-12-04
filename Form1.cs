using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OBS_Database
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        #region Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadListBoxOrt();
            ReloadListBoxBezirk();
            ReloadListBoxStrasse();

            btn_delete_ort.Visible = true;
            btnDeleteBezirk.Visible = false;
            btnDeleteStrasse.Visible = false;

            cb_bezirk_fk.DataSource = obsDataSet.selectAllOrt;
            cb_bezirk_fk.DisplayMember = "OName";
            cb_bezirk_fk.ValueMember = "OName";

            cb_strasse_fk.DataSource = obsDataSet.selectAllBezirk;
            cb_strasse_fk.DisplayMember = "BName";
            cb_strasse_fk.ValueMember = "BName";

            lstPK.Visible = false;
        }
        #endregion

        #region Insert Ort
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

            ReloadListBoxOrt();


            txtOEZahl.Text = null;
            txtOName.Text = null;
            txtOPLZ.Text = null;
            txtOID.Text = null;
            txtOID.Focus();
        }
        #endregion

        #region Insert Bezirk
        private void btnInsertBezirk_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);

            SqlCommand cmd = new SqlCommand("insertBezirk", con);

            cmd.CommandType = CommandType.StoredProcedure;


            string oname = cb_bezirk_fk.Text;
            int oid = get_OID_from_OName(oname);


            cmd.Parameters.Add("@inBOID", SqlDbType.Int).Value = oid;
            try
            {
                cmd.Parameters.Add("@inBID", SqlDbType.Int).Value = Int32.Parse(txtBID.Text);
            }
            catch
            {
                MessageBox.Show("Die Bezirks ID darf keine Buchstaben enthalten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBID.Text = null;
                txtBID.Focus();
            }
            cmd.Parameters.Add("@inBPLZ", SqlDbType.VarChar).Value = txtBPLZ.Text;
            cmd.Parameters.Add("@inBName", SqlDbType.VarChar).Value = txtBName.Text;
            try
            {
                cmd.Parameters.Add("@inBEZAHL", SqlDbType.Int).Value = Int32.Parse(txtBEZahl.Text);
            }
            catch
            {
                MessageBox.Show("Die Einwohneranzahl darf keine Buchstaben enthalten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBEZahl.Text = null;
                txtBEZahl.Focus();
            }


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

            ReloadListBoxBezirk();

            txtBID.Text = null;
            txtBEZahl.Text = null;
            txtBName.Text = null;
            txtBPLZ.Text = null;
            txtBID.Focus();

        }
        #endregion

        #region Insert Strasse
        private void btnInsertStrasse_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);

            SqlCommand cmd = new SqlCommand("insertStrasse", con);

            cmd.CommandType = CommandType.StoredProcedure;


            string bname = cb_strasse_fk.Text;
            int bid = get_BID_from_BName(bname);


            cmd.Parameters.Add("@inSBID", SqlDbType.Int).Value = bid;
            try
            {
                cmd.Parameters.Add("@inSID", SqlDbType.Int).Value = Int32.Parse(txtSID.Text);
            }
            catch
            {
                MessageBox.Show("Die Strassen ID darf keine Buchstaben enthalten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSID.Text = null;
                txtSID.Focus();
            }
            cmd.Parameters.Add("@inSPLZ", SqlDbType.VarChar).Value = txtSPLZ.Text;
            cmd.Parameters.Add("@inSName", SqlDbType.VarChar).Value = txtSName.Text;
            try
            {
                cmd.Parameters.Add("@inSEZAHL", SqlDbType.Int).Value = Int32.Parse(txtSEZahl.Text);
            }
            catch
            {
                MessageBox.Show("Die Einwohneranzahl darf keine Buchstaben enthalten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSEZahl.Text = null;
                txtSEZahl.Focus();
            }


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

            ReloadListBoxStrasse();

            txtSID.Text = null;
            txtSEZahl.Text = null;
            txtSName.Text = null;
            txtSPLZ.Text = null;
            txtSID.Focus();

        }
        #endregion

        #region Delete Ort
        private void btn_delete_ort_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("deleteFromOrt", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@inOID", SqlDbType.Int).Value = (Int32)lstID.SelectedValue;


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

            ReloadListBoxOrt();
        }
        #endregion

        #region Delete Bezirk
        private void btnDeleteBezirk_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("deleteFromBezirk", con);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@inBID", SqlDbType.Int).Value = (Int32)(lstID.SelectedValue);


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

            ReloadListBoxBezirk();

        }
        #endregion

        #region Delete Strasse
        private void btnDeleteStrasse_Click(object sender, EventArgs e)
        {
            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";

            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("deleteFromStrasse", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@inSID", SqlDbType.Int).Value = (Int32)lstID.SelectedValue;

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

            ReloadListBoxStrasse();
        }
        #endregion

        #region Radio Buttons
        private void radioStateChanged(object sender, EventArgs e)
        {
            if (rb_ort.Checked)
            {
                lstPK.Visible = false;
                btn_delete_ort.Visible = true;
                btnDeleteBezirk.Visible = false;
                btnDeleteStrasse.Visible = false;

                lstID.DataSource = obsDataSet.selectAllOrt;
                lstID.DisplayMember = "OID";
                lstID.ValueMember = "OID";

                lstName.DataSource = obsDataSet.selectAllOrt;
                lstName.DisplayMember = "OName";
                lstName.ValueMember = "OName";

                lstPLZ.DataSource = obsDataSet.selectAllOrt;
                lstPLZ.DisplayMember = "OPLZ";
                lstPLZ.ValueMember = "OPLZ";

                lstEZahl.DataSource = obsDataSet.selectAllOrt;
                lstEZahl.DisplayMember = "OEZahl";
                lstEZahl.ValueMember = "OEZahl";
            }
            else if (rb_bezirk.Checked)
            {

                lstPK.Visible = true;
                btn_delete_ort.Visible = false;
                btnDeleteBezirk.Visible = true;
                btnDeleteStrasse.Visible = false;

                String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();


                String sqlQuery = "SELECT bezirk.BOID, bezirk.BID, bezirk.BName, bezirk.BPLZ, bezirk.BEZahl, ort.OName FROM bezirk JOIN ort ON bezirk.BOID = ort.OID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, con))
                {
                    DataSet combinedDataSet = new DataSet();
                    adapter.Fill(combinedDataSet, "CombinedData");

                    lstPK.DataSource = combinedDataSet.Tables["CombinedData"];
                    lstPK.DisplayMember = "OName";
                    lstPK.ValueMember = "OName";

                    lstID.DataSource = combinedDataSet.Tables["CombinedData"];
                    lstID.DisplayMember = "BID";
                    lstID.ValueMember = "BID";

                    lstName.DataSource = combinedDataSet.Tables["CombinedData"];
                    lstName.DisplayMember = "BName";
                    lstName.ValueMember = "BName";

                    lstPLZ.DataSource = combinedDataSet.Tables["CombinedData"];
                    lstPLZ.DisplayMember = "BPLZ";
                    lstPLZ.ValueMember = "BPLZ";

                    lstEZahl.DataSource = combinedDataSet.Tables["CombinedData"];
                    lstEZahl.DisplayMember = "BEZahl";
                    lstEZahl.ValueMember = "BEZahl";
                }

                con.Close();
            }
            else if (rb_strasse.Checked)
            {

                lstPK.Visible = true;
                btn_delete_ort.Visible = false;
                btnDeleteBezirk.Visible = false;
                btnDeleteStrasse.Visible = true;

                String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();


                string sqlQuery = "SELECT strasse.SBID, strasse.SID, strasse.SName, strasse.SPLZ, strasse.SEZahl, bezirk.BName FROM strasse JOIN bezirk ON strasse.SBID = bezirk.BID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, con))
                {
                    DataSet combinedDataSet = new DataSet();
                    adapter.Fill(combinedDataSet, "CombinedStrassenData");

                    lstPK.DataSource = combinedDataSet.Tables["CombinedStrassenData"];
                    lstPK.DisplayMember = "BName";
                    lstPK.ValueMember = "BName";

                    lstID.DataSource = combinedDataSet.Tables["CombinedStrassenData"];
                    lstID.DisplayMember = "SID";
                    lstID.ValueMember = "SID";

                    lstName.DataSource = combinedDataSet.Tables["CombinedStrassenData"];
                    lstName.DisplayMember = "SName";
                    lstName.ValueMember = "SName";

                    lstPLZ.DataSource = combinedDataSet.Tables["CombinedStrassenData"];
                    lstPLZ.DisplayMember = "SPLZ";
                    lstPLZ.ValueMember = "SPLZ";

                    lstEZahl.DataSource = combinedDataSet.Tables["CombinedStrassenData"];
                    lstEZahl.DisplayMember = "SEZahl";
                    lstEZahl.ValueMember = "SEZahl";
                }

                con.Close();
            }
        }
        #endregion

        #region GET OID
        private int get_OID_from_OName(string oname)
        {
            int oid = 0;

            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";
            String sqlCommand = $"SELECT OID FROM ort WHERE OName='{oname}'";

            SqlConnection con = new SqlConnection(strCon);

            SqlCommand cmd = new SqlCommand(sqlCommand, con);

            con.Open();
            try
            {
                oid = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            return oid;
        }
        #endregion

        #region GET BID
        private int get_BID_from_BName(string bname)
        {
            int bid = 0;

            String strCon = "Data Source=(LocalDB)\\inf31;Initial Catalog = obs; Integrated Security = True";
            String sqlCommand = $"SELECT BID FROM bezirk WHERE BName='{bname}'";

            SqlConnection con = new SqlConnection(strCon);

            SqlCommand cmd = new SqlCommand(sqlCommand, con);

            con.Open();
            try
            {
                bid = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            return bid;
        }
        #endregion

        #region Reload List Boxen
        private void ReloadListBoxOrt()
        {
            this.selectAllOrtTableAdapter.Fill(this.obsDataSet.selectAllOrt);
        }
        
        private void ReloadListBoxBezirk()
        {
            this.selectAllBezirkTableAdapter.Fill(this.obsDataSet.selectAllBezirk);

        }

        private void ReloadListBoxStrasse()
        {
            this.selectAllStrasseTableAdapter1.Fill(this.obsDataSet.selectAllStrasse);

        }
        #endregion
    }
}
