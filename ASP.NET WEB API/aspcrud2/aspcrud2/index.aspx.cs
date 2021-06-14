using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System;





namespace aspcrud2

{
    public partial class index : System.Web.UI.Page
    {

        string connectionString = @"Server=localhost;Database=aspcruddb;Uid=root;Pwd=ravi@chinni";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clear();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MySqlCommand sqlcmd = new MySqlCommand("productAddorEdit", sqlCon);
                    sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("_productid", Convert.ToInt32(hfProductID.Value == "" ? "0" : hfProductID.Value));
                    sqlcmd.Parameters.AddWithValue("_product", txtProduct.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("_price", Convert.ToDecimal(txtPrice.Text.Trim()));
                    sqlcmd.Parameters.AddWithValue("_count", Convert.ToInt32(txtCount.Text.Trim()));
                    sqlcmd.Parameters.AddWithValue("_description", txtDescription.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    Clear();

                    lblSuccessMessage.Text = "Submitted Scuccessfully";
                }
            }
            catch (Exception ex)
            {

                lblErrorMessage.Text = ex.Message;
            }

        }
        void Clear()
        {
            hfProductID.Value = "";
            txtProduct.Text = txtPrice.Text = txtCount.Text = txtDescription.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            lblErrorMessage.Text = lblSuccessMessage.Text = "";

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
