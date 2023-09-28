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
    public partial class frmItemEntry : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=foodCafe;Trusted_Connection=True;");

        public frmItemEntry()
        {
            InitializeComponent();
        }

        private void frmItemEntry_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select categoryId ,categoryName from category";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbCategory.DataSource = ds.Tables[0];
            cmbCategory.DataSource = ds.Tables[0];
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into items(itemName,itemPrice,picture,available,madeDate,categoryId) values(@n,@pr,@pi,@a,@m,@c)";
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@pr", txtPrice.Text.ToString());
            cmd.Parameters.AddWithValue("@a", chkPresent.Checked.ToString());
            cmd.Parameters.AddWithValue("@m", dateTimePicker1.Value);
            cmd.Parameters.Add(new SqlParameter("@pi", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@c", cmbCategory.SelectedValue);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Inserted successfully!!!";
            con.Close();
        }

        
    }
}
