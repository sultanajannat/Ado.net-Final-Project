using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void allFoodCategoryNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory fs =new frmCategory();
            fs.Show();
            fs.MdiParent= this; 
        }

        private void itemEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemEntry fit = new frmItemEntry();  
            fit.Show();
            fit.MdiParent = this;   
        }

        private void itemUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemUpdateDelete fup = new frmItemUpdateDelete();    
            fup.Show(); 
            fup.MdiParent = this;   

        }

        private void itemsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemView iv= new frmItemView();  
            iv.Show();  
            iv.MdiParent = this;    
        }

       
    }
}
