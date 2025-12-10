using AnyStore.BLL;
using AnyStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.title = txtTitle.Text;
            c.discription = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromUsername(loggeduser);
            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Category Inserted Successfully.");
                Clear();
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Insert New Category.");
            }

        }

        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;

        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.discription = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDfromUsername(loggeduser);
            c.added_by = usr.id;

            bool success = dal.Update(c);

            if (success == true)
            {
                MessageBox.Show("Category Updated Successfully.");
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update Category.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoryID.Text);

            bool success = dal.Delte(c);

            if (success == true)
            {
                MessageBox.Show("Category Delete Successfully.");
                Clear();
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fialed to Delete Category.");
            }
        }
    }
}
