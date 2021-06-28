
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuelStationApp {
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm {

        public SqlConnection _SqlConnection { get; set; }
        private DataSet MasterData = new DataSet();

        //private GridView gridView = new GridView();
        public MainForm(SqlConnection sqlConnection) {
            _SqlConnection = sqlConnection;
            InitializeComponent();
        }

       
        private void MainForm_Load(object sender, EventArgs e) {

        }

       

        private void getTransactions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetTransactionData();
            gridControl1.DataSource = MasterData.Tables[0];
        }

        private void getAllItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
           //TODO: 
        }
       
        private void getCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridControl1.MainView = gridCustomers;
            GetCustomerData();
            gridControl1.DataSource = MasterData.Tables[0];

            //gridControl1.Refresh();
        }

        private void saveCustomerChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            UpdateCustomer();
        }
        private void deleteCustomer2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DeleteCustomer();
        }

        private void AppendLog(string name, object message) {
            // txtLog.AppendText(string.Format("{0}={1}{2}", name, message, Environment.NewLine));
        }

        private void GetCustomerData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID],[Name],[Surname],[CardNumber] FROM CUSTOMERS", _SqlConnection);

                adapter.Fill(MasterData);
               

            }
            catch (Exception ex) {

            }
        }
        private void GetTransactionData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID],[TotalValue] FROM [Transaction]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }


        private void DeleteCustomer() {

            try {


                object CellValue = gridTransactions.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Customers WHERE ID = '" + _id + "';", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
            // gridView1.RefreshData();

        }
        private void UpdateCustomer() {

            try {

                object CellValue = gridTransactions.GetFocusedRowCellValue("Name");
                object CellValue2 = gridTransactions.GetFocusedRowCellValue("Surname");
                string _name = CellValue.ToString();
                string _surname = CellValue2.ToString();
                MessageBox.Show(_surname);
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Customers SET Surname ='" + _surname + "'  WHERE Name = '" + _name + "';", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }




        }

    }
}
