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

namespace CafeManagementSystem
{
    public partial class frmItemView : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=foodCafe;Trusted_Connection=True;");

        public frmItemView()
        {
            InitializeComponent();
        }

        private void frmItemView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select i.itemId,i.itemName,i.itemPrice,i.picture,i.available,i.madeDate,c.categoryName from items i inner join category c on i.categoryId=c.categoryId", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


    }
}
