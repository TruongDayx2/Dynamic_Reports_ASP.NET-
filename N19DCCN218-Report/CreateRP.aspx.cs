using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N19DCCN218_Report
{
    public partial class CreateRP : System.Web.UI.Page
    {
        public static List<String> selectedTableNames = new List<string>(); //tên các table đang được chọn   
        //int checkQr=0;    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.GetTableName();
   
        }
        // Lấy Table từ data
        private void GetTableName()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLVTConnectionString"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = "select object_id, name from sys.tables where name <> 'sysdiagrams'";

                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem item = new ListItem();
                            item.Text = sdr["name"].ToString();
                            item.Value = sdr["object_id"].ToString();
                            CheckBoxListTable.Items.Add(item);
                        }
                    }
                    conn.Close();
                }
            }
        }
        // Sự kiện click table
        protected void CheckBoxListTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTableNames.Clear();
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";
            CBLColumn1.Items.Clear();
            CBLColumn2.Items.Clear();
            CBLColumn3.Items.Clear();
            CBLColumn4.Items.Clear();
            CBLColumn5.Items.Clear();
            CBLColumn6.Items.Clear();
            CBLColumn7.Items.Clear();
            CBLColumn8.Items.Clear();
            CBLColumn9.Items.Clear();
            CBLColumn10.Items.Clear();

            txtQuery.Text = "";
            int k = 0;

            foreach (ListItem item in CheckBoxListTable.Items)
                if (item.Selected)
                {
                    k += 1;
                    selectedTableNames.Add(item.Text);
                    GetColumnName(item.Value, item.Text, k);
                }

            GridView1.Controls.Clear();
        }
        // Lấy column từ data
        private void GetColumnName(String tableID, String tableName,int k)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLVTConnectionString"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = "select object_id, name from sys.columns where object_id = " + tableID;

                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem item = new ListItem();
                            item.Text = sdr["name"].ToString();
                            item.Value = tableName;
                            switch (k)
                            {
                                case 1:
                                    Label1.Text = item.Value;
                                    CBLColumn1.Items.Add(item);
                                    break;
                                case 2:
                                    Label2.Text = item.Value;
                                    CBLColumn2.Items.Add(item);
                                    break;
                                case 3:
                                    Label3.Text = item.Value;
                                    CBLColumn3.Items.Add(item);
                                    break;
                                case 4:
                                    Label4.Text = item.Value;
                                    CBLColumn4.Items.Add(item);
                                    break;
                                case 5:
                                    Label5.Text = item.Value;
                                    CBLColumn5.Items.Add(item);
                                    break;
                                case 6:
                                    Label6.Text = item.Value;
                                    CBLColumn6.Items.Add(item);
                                    break;
                                case 7:
                                    Label7.Text = item.Value;
                                    CBLColumn7.Items.Add(item);
                                    break;
                                case 8:
                                    Label8.Text = item.Value;
                                    CBLColumn8.Items.Add(item);
                                    break;
                                case 9:
                                    Label9.Text = item.Value;
                                    CBLColumn9.Items.Add(item);
                                    break;
                                case 10:
                                    Label10.Text = item.Value;
                                    CBLColumn10.Items.Add(item);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }

        protected void CBLColumn1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);              
            }
            //checkQr = dt.Rows.Count;           
            //txtQuery.Text =  checkQr.ToString();
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
        }

        protected void CBLColumn2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn7_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn8_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void CBLColumn10_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên cột", Type.GetType("System.String"));
            dt.Columns.Add("Tên bảng", Type.GetType("System.String"));
            foreach (ListItem item in CBLColumn1.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn2.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn3.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn4.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn5.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn6.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn7.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn8.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn9.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            foreach (ListItem item in CBLColumn10.Items)
            {
                if (item.Selected) dt.Rows.Add(item.Text, item.Value);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }



        protected void ButtonClearColumn_Click(object sender, EventArgs e)
        {
            GridView1.Controls.Clear();
            selectedTableNames.Clear();
            
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";
            CBLColumn1.Items.Clear();
            CBLColumn2.Items.Clear();
            CBLColumn3.Items.Clear();
            CBLColumn4.Items.Clear();
            CBLColumn5.Items.Clear();
            CBLColumn6.Items.Clear();
            CBLColumn7.Items.Clear();
            CBLColumn8.Items.Clear();
            CBLColumn9.Items.Clear();
            CBLColumn10.Items.Clear();
           
            int k = 0;

            foreach (ListItem item in CheckBoxListTable.Items)
                if (item.Selected)
                {
                    k += 1;
                    selectedTableNames.Add(item.Text);
                    GetColumnName(item.Value, item.Text, k);
                }

            txtQuery.Text = "";
        }
        public String GetQuanHe(String a_id, String b_id)
        {
            List<String> values = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLVTConnectionString"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = "exec sp_TimFK " + a_id + ", " + b_id;

                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            values.Add(sdr["table_name"].ToString() + "." + sdr["column_name"].ToString());
                        }
                    }
                    conn.Close();
                }
            }
            return string.Join(" = ", values);
        }
        protected void ButtonQuery_Click(object sender, EventArgs e)
        {
            bool checkQr =false;
            foreach (GridViewRow r in GridView1.Rows)
                if (r.Cells[3].Text != "")
                {
                    checkQr = true;
                    break;
                }
                else
                {
                    checkQr = false;
                    break;
                }

            if (checkQr)
            {
                List<String> columns = new List<string>();
                List<String> conditions = new List<string>();
                List<String> groups = new List<string>();
                List<String> sorts = new List<string>();
                List<String> havings = new List<string>();

                String query = "SELECT ";

                String column = "", table = "", sort = "", function = "", condition = "";

                if (selectedTableNames.Count > 1)
                {
                    String a_id, b_id, QuanHe;
                    for (int i = 0; i < selectedTableNames.Count - 1; i++)
                        for (int j = i + 1; j < selectedTableNames.Count; j++)
                        {
                            a_id = CheckBoxListTable.Items.FindByText(selectedTableNames[i]).Value;
                            b_id = CheckBoxListTable.Items.FindByText(selectedTableNames[j]).Value;
                            QuanHe = GetQuanHe(a_id, b_id);
                            // Thêm điều kiện sau where vào condition
                            if (!QuanHe.Equals(""))
                                conditions.Add(QuanHe);
                        }
                }
                //Lấy điều kiện người dùng chọn từ GridView
                foreach (GridViewRow row in GridView1.Rows)
                {

                    sort = (row.Cells[0].FindControl("DropDownList_Sort") as DropDownList).SelectedValue;
                    function = (row.Cells[1].FindControl("DropDownList_Function") as DropDownList).SelectedValue;
                    condition = (row.Cells[2].FindControl("txtDieuKien") as TextBox).Text;
                    column = row.Cells[3].Text;
                    table = row.Cells[4].Text;

                    //Xử lý hàm
                    if (function.Equals("Select"))
                        columns.Add(table + "." + column);
                    else if (function.Equals("Group by"))
                    {
                        columns.Add(table + "." + column);
                        groups.Add(columns[columns.Count - 1]);
                    }
                    else
                        columns.Add(function + "(" + table + "." + column + ")");

                    //Xử lý điều kiện
                    if (!condition.Equals(""))
                        if (function.Equals("Select") || function.Equals("Group by"))
                            conditions.Add(columns[columns.Count - 1] + " " + condition);
                        else
                            havings.Add(columns[columns.Count - 1] + " " + condition);

                    if (!sort.Equals("None"))
                        sorts.Add(columns[columns.Count - 1] + " " + sort);
                }
                //Tạo ra câu truy vấn
                query += string.Join(", ", columns) + " from " + string.Join(", ", selectedTableNames);

                //Nếu có điều kiện
                if (conditions.Count != 0)
                    query += " where " + string.Join(" and ", conditions);

                //Nếu có group by
                if (groups.Count != 0)
                    query += " group by " + string.Join(", ", groups);

                //Nếu có điều kiện sau khi group by
                if (havings.Count != 0)
                    query += " having " + string.Join(" and ", havings);

                //Nếu có sắp xếp
                if (sorts.Count != 0)
                    query += " order by " + string.Join(", ", sorts);

                txtQuery.Text = query;
            }          
        }

        protected void btnCreateRP_Click(object sender, EventArgs e)
        {
            if (txtQuery.Text != "")
            {
                Session["query"] = txtQuery.Text;
                Session["title"] = tbTieuDe.Text;
                Session["time"] = DateTime.Now.ToLocalTime();
                Response.Redirect("showRP.aspx");
                Server.Execute("showRP.aspx");
            }            
        }
    }
}