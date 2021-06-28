
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
      /*  private void GetTransactionData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID],[TotalValue] FROM [Transaction]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }*/


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
      /*  private void UpdateCustomer() {

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




        }*/

        //UpdateCustomer
        private void UpdateCustomer() {

            try {

                object CellValue = gridCustomer.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                object CellValueName = gridView1.GetFocusedRowCellValue("Name");
                string _name = CellValueName.ToString();
                object CellValueSurname = gridView1.GetFocusedRowCellValue("Surname");
                string _surname = CellValueSurname.ToString();
                object CellValueCardNumber = gridView1.GetFocusedRowCellValue("CardNumber");
                int _cardNumber =(int) CellValueCardNumber;

                MessageBox.Show(_surname);
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Customers SET Surname ='" + _surname + "' ,	[Name] ='" + _name + "' , CardNumber ='" + _cardNumber + "'WHERE ID = '" + _id + "';", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }

        }
        //GetEmployeeData
        private void GetEmployeeData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Name], [Surname], [DateStart], [DateEnd], [Salary] FROM [Employee]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //DeleteEmployee
        private void DeleteEmployee() {

            try {

                object CellValue = gridView3.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Employee WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }

        //UpdateEmployee
        private void UpdateEmployee() {

            try {

                object CellValueID = gridView3.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValueID;
                MessageBox.Show(_id.ToString());
                object CellValueName = gridView3.GetFocusedRowCellValue("Name");
                string _name = CellValueName.ToString();
                object CellValueSurname = gridView3.GetFocusedRowCellValue("Surname");
                string _surname = CellValueSurname.ToString();
                object CellValueDateStart = gridView3.GetFocusedRowCellValue("DateStart");
                DateTime _dateStart = (DateTime)CellValueDateStart;
                object CellValueDateEnd = gridView3.GetFocusedRowCellValue("DateEnd");
                DateTime _dateEnd = (DateTime)CellValueDateEnd;
                object CellValueSalary = gridView3.GetFocusedRowCellValue("Salary");
                decimal _salary = (decimal)CellValueSalary;

                MessageBox.Show(_surname);
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Employee SET Surname = '" + _surname + "',[Name] = '" + _name + "',DateStart = '" + _dateStart + "',[DateEnd] = '" + _dateEnd+"',[Salary] = "+ _salary +"WHERE ID = '"+ _id+"'; ", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }

        }
        //GetItemData
        private void GetItemData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Code], [Description], [ItemType], [Price], [Cost] FROM [Items]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //DeleteItems
        private void DeleteItems() {

            try {

                object CellValue = gridView4.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Items WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //UpdateItems
        private void UpdateItems() {

            try {

                object CellValueID = gridView3.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValueID;
                MessageBox.Show(_id.ToString());
                object CellValueCode = gridView3.GetFocusedRowCellValue("Code");
                string _code = CellValueCode.ToString();
                object CellValueDescription = gridView3.GetFocusedRowCellValue("Description");
                string _description = CellValueDescription.ToString();
                object CellValueItemType = gridView3.GetFocusedRowCellValue("ItemType");
                string _itemType = CellValueItemType.ToString();
                object CellValuePrice = gridView3.GetFocusedRowCellValue("Price");
                decimal _price = (decimal)CellValuePrice;
                object CellValueCost = gridView3.GetFocusedRowCellValue("Cost");
                decimal _cost = (decimal)CellValueCost;

             
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Items SET Code = '" + _code + "',[Description] = '" + _description + "',ItemType = '" + _itemType + "',[Price] = " + _price+",[Cost] = "+ _cost + " WHERE ID = '" + _id + "'; ", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }

        }
        //GetTransactionData
        private void GetTransactionData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Date], [CustomerID], [DiscountValue], [TotalValue] FROM [Transaction]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //DeleteTransaction
        private void DeleteTransaction() {

            try {

                object CellValue = gridView5.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Transaction WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //UpdateTransaction
        private void UpdateTransaction() {

            try {


                object CellValueID = gridView3.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValueID;
                MessageBox.Show(_id.ToString());
                object CellValueDate = gridView3.GetFocusedRowCellValue("Date");
                DateTime _date = (DateTime)CellValueDate;
                object CellValueCustomerID = gridView3.GetFocusedRowCellValue("CustomerID");//////////////////////
                Guid _customerID = (Guid)CellValueID;
                object CellValueDiscountValue = gridView3.GetFocusedRowCellValue("DiscountValue");
                decimal _discountValue = (decimal)CellValueDiscountValue;
                object CellValueTotalValue = gridView3.GetFocusedRowCellValue("TotalValue");
                decimal _totalValue = (decimal)CellValueTotalValue;


                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Transaction SET Date = '" + _date + "',[CustomerID] = '" + _customerID + "',DiscountValue = " + _discountValue + ",[TotalValue] = " + _totalValue +  " WHERE ID = '" + _id + "'; ", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }

        }
        //GetTransactionLineData
        private void GetTransactionLineData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [TransactionId], [ItemID], [Quantity], [ItemPrice], [Value] FROM [TransactionLine]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //DeleteTransactionLine
        private void DeleteTransactionLine() {

            try {

                object CellValue = gridView6.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM TransactionLine WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //GetLedgerData
        private void GetLedgerData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [DateFrom], [DateTo], [Income], [Expences], [Total] FROM [Ledger]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //DeleteLedger
        private void DeleteLedger() {

            try {

                object CellValue = gridView7.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Ledger WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }



    }
}
