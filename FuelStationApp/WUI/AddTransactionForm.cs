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
        public int cardNumber { get; set; }
        public string TransactionDate { get; set; }
        public Guid CustomerID { get; set; }
        public Guid TransactionID { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal TotalValue { get; set; }
        public decimal FinalPriceAfterDiscount { get; set; }
        public AddTransactionForm(DataSet itemData, SqlConnection _sqlConnectionTrans) {
            _SqlConnectionTrans = _sqlConnectionTrans;
            ItemData = itemData;
            InitializeComponent();

        }

        private void AddTransaction_Load(object sender, EventArgs e) {

           
            gridControl2.DataSource = ItemData.Tables[0];
            TransactionID = Guid.NewGuid();
            TransactionDate = DateTime.Now.ToString("yyyyMMdd");
            DiscountPercentage = 0;
            TotalValue = 0;
         

            gridControl2.Enabled = false;

        }
        public void GetTransactionCustomer() {

            try {
               

                cardNumber = Convert.ToInt32(ctrlCCN.EditValue);

                CustomerData = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID] FROM Customers WHERE [CardNumber] = " + cardNumber + ";", _SqlConnectionTrans);
                adapter.Fill(CustomerData);
                CustomerID = (Guid)CustomerData.Tables[0].Rows[0].ItemArray[0];

                gridControl2.Enabled = true;



            }
            catch (Exception) {
                MessageBox.Show("Customer not found");
            }


        }
        public void AddItems() {

            DataSet TransactionData1 = new DataSet();

            SqlDataAdapter adapter1 = new SqlDataAdapter($"SELECT ID ,ItemType,TransactionID  FROM TransactionLine WHERE [ItemType]='0' AND TransactionID='{TransactionID}'", _SqlConnectionTrans);
            adapter1.Fill(TransactionData1);
            string itemType = string.Empty;
            switch (gridView1.GetFocusedRowCellValue("ItemType")) {
                case "Fuel":

                    itemType = "0";
                    break;
                case "Product":

                    itemType = "1";
                    break;
                case "Service":

                    itemType = "2";
                    break;


                default:
                    break;
            }
           // string itemType = Convert.ToString(gridView1.GetFocusedRowCellValue("ItemType"));
            if ((TransactionData1.Tables[0].Rows.Count == 0 && itemType == "0") || itemType != "0") {


                Guid itemId = (Guid)gridView1.GetFocusedRowCellValue("ID");

                string description = Convert.ToString(gridView1.GetFocusedRowCellValue("Description"));
                decimal _value = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Price")) * Convert.ToDecimal(ctrlQuantity.EditValue);
                string itemprice = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Price")).ToString().Replace(',', '.');
                string quantity = Convert.ToDecimal(ctrlQuantity.EditValue).ToString().Replace(',', '.');
                Guid id = Guid.NewGuid();

                string value = (_value).ToString().Replace(',', '.');
                if (itemType == "0" && _value > 50) {
                    DiscountPercentage = 0.1m;
                }
                SqlCommand command = new SqlCommand("INSERT INTO TransactionLine ([ID],[TransactionID],[ItemID],[Quantity],[ItemPrice],[Value],[Description],[ItemType]) VALUES ('" + id + "','" + TransactionID + "','" + itemId + "','" + quantity + "','" + itemprice + "','" + value + "','" + description + "','" + itemType + "')", _SqlConnectionTrans);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                TransactionData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("SELECT * FROM TransactionLine WHERE TransactionID='{0}' ", TransactionID), _SqlConnectionTrans);
                adapter.Fill(TransactionData);
                TotalValue += _value;
                ctrlPBD.EditValue = TotalValue;
                gridControl3.DataSource = TransactionData.Tables[0];
            }
            else {

                MessageBox.Show("Only one item of Fuel Type is allowed!");
            }


        }
        public void AddITransaction() {

            SqlCommand command = new SqlCommand($"INSERT INTO [Transaction] ([ID],[Date],[CustomerID],[DiscountValue],[TotalValue]) VALUES ('{TransactionID}','{TransactionDate}','{CustomerID}','{FinalPriceAfterDiscount.ToString().Replace(',','.')}','{TotalValue.ToString().Replace(',', '.')}')", _SqlConnectionTrans);

            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
        }

        private void labelControl3_Click(object sender, EventArgs e) {

        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void ctrlCCN_EditValueChanged(object sender, EventArgs e) {

        }

        private void btnOK_Click(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(ctrlTotalPrice.EditValue.ToString())) { 
            AddITransaction();
            Close();
            }
            else {
                MessageBox.Show("Please press the Calculate Button!");
            }
        }

        private void ctrlCCN_Leave(object sender, EventArgs e) {

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
           
            GetTransactionCustomer();
        }

        private void btQuantity_Click(object sender, EventArgs e) {

            AddItems();

        }

        private void lblQuantity_Click(object sender, EventArgs e) {

        }

        private void ctrlQuantity_EditValueChanged(object sender, EventArgs e) {

        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            FinalPriceAfterDiscount = TotalValue * (1 - DiscountPercentage);
            ctrlTotalPrice.EditValue = FinalPriceAfterDiscount;
            ctrlDiscount.EditValue = 100 * DiscountPercentage;
            ctrlPBD.EditValue = TotalValue;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}