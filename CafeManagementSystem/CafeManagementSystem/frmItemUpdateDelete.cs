using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class frmItemUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=foodCafe;Trusted_Connection=True;");

        public frmItemUpdateDelete()
        {
            InitializeComponent();
        }

        private void frmItemUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadSubject();

        }

        private void LoadSubject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select categoryId ,categoryName from category";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
           cmbCategory.DataSource = ds.Tables[0];
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select itemId,itemName,itemPrice,picture,available,madeDate,categoryId from items where itemId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0][1].ToString();
               txtPrice.Text = dt.Rows[0][2].ToString();
              
                cmbCategory.SelectedValue = dt.Rows[0][6].ToString();
                dateTimePicker1.Text = dt.Rows[0][5].ToString();
                //chkGender.Text = dt.Rows[0][7].ToString();
                string presentStatus = dt.Rows[0][4].ToString();
                if (presentStatus == "True")
                {
                    chkPresent.Checked = true;
                }
                else
                {
                    chkPresent.Checked = false;
                }
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][3]);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;

            }
            con.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            
            Image img = Image.FromFile(txtPicture.Text);

            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE items SET itemName=@n,itemPrice=@pr,picture=@pi,available=@a,madeDate=@m,categoryId=@c where itemId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@pr", txtPrice.Text.ToString());
            cmd.Parameters.AddWithValue("@a", chkPresent.Checked.ToString());
            cmd.Parameters.AddWithValue("@m", dateTimePicker1.Value);
            cmd.Parameters.Add(new SqlParameter("@pi", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@c", cmbCategory.SelectedValue);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Updated successfully!!!";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from items WHERE itemId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);

            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted successfully!!!";
            con.Close();
        }
    }
}
