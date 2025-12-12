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
using System.Transactions;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frmpurchaseAndSales : Form
    {
        public frmpurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DeaCustDAL dcDAL = new DeaCustDAL();
        productDAL pDAL = new productDAL();
        userDAL uDAL = new userDAL();
        transactionDAL tDAL = new transactionDAL();
        transactionDetailDAL tdDAL = new transactionDetailDAL();

        DataTable transactionDT = new DataTable();

        private void frmpurchaseAndSales_Load(object sender, EventArgs e)
        {
            string type = frmUserDashboard.transactionType;
            lblTop.Text = type;

            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword == "")
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            DeaCustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

            txtName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchProduct.Text;

            if (keyword == "")
            {
                txtNameProduct.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
                return;
            }


            productsBLL p = pDAL.GetproductsForTransaction(keyword);

            txtNameProduct.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtNameProduct.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQty.Text);

            decimal Total = Rate * Qty;

            decimal subtotal = decimal.Parse(txtSubTotal.Text);
            subtotal = subtotal + Total;

            if (productName == "")
            {
                MessageBox.Show("Select the Product first. Try Again.");
            }
            else
            {
                transactionDT.Rows.Add(productName, Rate, Qty,Total);

                dgvAddedProducts.DataSource = transactionDT;

                txtSubTotal.Text = subtotal.ToString();

                txtSearchProduct.Text = "";
                txtNameProduct.Text = "";
                txtInventory.Text = "0.00";
                txtRate.Text = "0.00";
                txtQty.Text = "0.00";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtDiscount.Text;

            if (value == "")
            {
                MessageBox.Show("Please Add Discount First.");
            }else
            {
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);


                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            string check = txtGrandTotal.Text;

            if (check == "")
            {
                MessageBox.Show("Calculate the Discount and set the Grand Total First.");
            }else
            {
                decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                decimal vat = decimal.Parse(txtVat.Text);
                decimal granTotalWithVat = ((100 + vat) / 100) * previousGT;

                txtGrandTotal.Text = granTotalWithVat.ToString();
            }
        }

        private void txtPaidAmmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmmount = decimal.Parse(txtPaidAmmount.Text);

            decimal returnAmmount = paidAmmount - grandTotal;

            txtReturnAmmount.Text = returnAmmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            transactionsBLL transaction = new transactionsBLL();

            transaction.type = lblTop.Text;

            string deaCustName = txtName.Text;

            DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);


            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtVat.Text);
            transaction.discount = decimal.Parse(txtDiscount.Text);

            string username = frmLogin.loggedIn;
            userBLL u = uDAL.GetIDfromUsername(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            bool success = false;

            using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                for(int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    tranactionDeatilBLL transactionDetail = new tranactionDeatilBLL();

                    string ProductName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDAL.GetProductIDFromName(ProductName);
                    transactionDetail.product_id = p.id;


                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);

                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;


                    //
                    string transactionType = lblTop.Text;
                    bool x=false;

                    if (transactionType == "Purchase")
                    {
                         x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }else if (transactionType == "Sales")
                    {
                         x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }

                    bool y = tdDAL.InsertTransactionDetail(transactionDetail);

                    success = w && x && y;

                }
                

                if (success == true)
                {
                    scope.Complete();

                    MessageBox.Show("Transaction Completed Successfully.");
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";

                    txtNameProduct.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQty.Text = "0";

                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVat.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmmount.Text = "0";
                    txtReturnAmmount.Text = "0";

                }
                else
                {
                    MessageBox.Show("Transaction Failed.");
                }

            }
        }
    }
}
