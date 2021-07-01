using DevExpress.XtraEditors;
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
        public int j { get; set; } = 0;
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
            TransactionData = new DataSet();
            Guid selectedID = (Guid)gridView1.GetFocusedRowCellValue("ID");
            DataRow selectedRow=ItemData.Tables[0].Select(String.Format("ID='{0}'", selectedID.ToString()))[0];
           
            for (int i = 0; i < selectedRow.ItemArray.Length; i++) {

                TransactionData.Tables[0].Rows[j].ItemArray[i]= selectedRow.ItemArray[i];
                
            }
            j++;
            gridControl2.DataSource = TransactionData.Tables[0];

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
    }
}