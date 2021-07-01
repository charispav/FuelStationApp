using DevExpress.XtraEditors;
using FuelStationApp.Impl;
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

namespace FuelStationApp.WUI {
    public partial class AddTransactionForm : DevExpress.XtraEditors.XtraForm {
        public DataSet ItemData { get; set; }
        public DataSet CustomerData { get; set; }
        public DataSet TransactionData { get; set; }
        public SqlConnection _SqlConnectionTrans { get; set; }
        public int  cardNumber { get; set; }

        public Guid TransactionID { get; set; } = Guid.NewGuid();
    public AddTransactionForm(DataSet itemData, SqlConnection _sqlConnectionTrans) {
            _SqlConnectionTrans = _sqlConnectionTrans;
            ItemData = itemData;
            InitializeComponent();

        }

        private void AddTransaction_Load(object sender, EventArgs e) {
            gridControl2.Visible = false;
            gridControl2.DataSource = ItemData.Tables[0];
            

        }
        public void getTransactionCustomer() {
           
            try {
                cardNumber = Convert.ToInt32(ctrlCCN.EditValue);

                CustomerData = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter ("SELECT [ID] FROM Customers WHERE [CardNumber] = " + cardNumber + ";", _SqlConnectionTrans);
                adapter.Fill(CustomerData);
             
                   
                if (!string.IsNullOrEmpty( Convert.ToString(CustomerData.Tables[0].Rows[0].ItemArray[0]) ) ) 
                    gridControl2.Visible = true;
                
              
              
            }
            catch (Exception) {
                MessageBox.Show("Customer not found");
            }

          //  return true;
        }
        public void AddItems() {
            Guid itemId = (Guid)gridView1.GetFocusedRowCellValue("ID");
            //string code = Convert.ToString(gridView1.GetFocusedRowCellValue("Code"));
            Int16 itemType = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ItemType"));
            string description = Convert.ToString(gridView1.GetFocusedRowCellValue("Description"));

            string itemprice = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Price")).ToString().Replace(',','.');
            string quantity = Convert.ToDecimal(ctrlQuantity.EditValue).ToString().Replace(',', '.');
            Guid id = Guid.NewGuid();
            string value = (Convert.ToDecimal(quantity) * Convert.ToDecimal(itemprice)).ToString().Replace(',','.');
            SqlDataAdapter adapter = new SqlDataAdapter($"INSERT INTO TransactionLine ([ID],[TransactionID],[ItemID],[Quantity],[ItemPrice],[Value],[Description],[ItemType]) VALUES ('{id}','{TransactionID}','{itemId}','{quantity}','{itemprice}','{value}','{description}',{itemType})", _SqlConnectionTrans);

            adapter.Fill(TransactionData);
           // SqlCommand command = new SqlCommand($"SELECT * FROM ")

            gridControl3.DataSource = TransactionData.Tables[0];


        }

        private void labelControl3_Click(object sender, EventArgs e) {

        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void ctrlCCN_EditValueChanged(object sender, EventArgs e) {

        }

        private void btnOK_Click(object sender, EventArgs e) {
           
        }

        private void ctrlCCN_Leave(object sender, EventArgs e) {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            
            getTransactionCustomer();
        }

        private void btQuantity_Click(object sender, EventArgs e) {
       
          AddItems();
        }

        private void lblQuantity_Click(object sender, EventArgs e) {

        }

        private void ctrlQuantity_EditValueChanged(object sender, EventArgs e) {

        }
    }
}