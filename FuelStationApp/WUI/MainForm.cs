
using DevExpress.XtraGrid.Views.Grid;
using FuelStationApp.Impl;
using FuelStationApp.WUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        }

      

        private void getAllItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetItemData();
        }
       
        private void getCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            
            GetCustomerData();
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
            //gridControl1.DataSource = null;
         

            //gridControl1.RefreshDataSource();
            //gridControl1.DataSource = null;
            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID],[Name],[Surname],[CardNumber] FROM CUSTOMERS", _SqlConnection);

                MasterData = new DataSet();
                adapter.Fill(MasterData);
                

            }
            catch (Exception ex) {

            }

           
            gridControl1.MainView = gridCustomers;
            gridControl1.DataSource = MasterData.Tables[0];

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

                //Guid CellValueID = (Guid)gridCustomers.GetFocusedRowCellValue("ID");
                object CellValue = gridCustomers.GetFocusedRowCellValue("ID");
                Guid _id = (Guid) CellValue;

                //MessageBox.Show(_id.ToString());
                object CellValueName = gridCustomers.GetFocusedRowCellValue("Name");
                string _name = CellValueName.ToString();
                object CellValueSurname = gridCustomers.GetFocusedRowCellValue("Surname");
                string _surname = CellValueSurname.ToString();
                object CellValueCardNumber = gridCustomers.GetFocusedRowCellValue("CardNumber");
                int _cardNumber = (int) CellValueCardNumber;
               // Customer c1 = new Customer(new Person(new Entity(_id),_name,_surname ), _cardNumber);
                
                
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Customers SET Surname ='" + _surname + "' ,	[Name] ='" + _name + "' , CardNumber ='" + _cardNumber + "'WHERE ID = '" + _id + "';", _SqlConnection);

                adapter.Fill(MasterData);
                MessageBox.Show("Database Updated!");
                
            }
            catch (Exception ex) {

            }

        }
        //GetEmployeeData
        private void GetEmployeeData() {
           
            gridControl1.MainView = gridEmployees;
            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Name], [Surname], [DateStart], [DateEnd], [Salary] FROM [Employee]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
            gridControl1.DataSource = MasterData.Tables[0];
        }
        //DeleteEmployee
        private void DeleteEmployee() {

            try {

                object CellValue = gridEmployees.GetFocusedRowCellValue("ID");
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

                object CellValueID = gridEmployees.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValueID;
                object CellValueName = gridEmployees.GetFocusedRowCellValue("Name");
                string _name = CellValueName.ToString();
                object CellValueSurname = gridEmployees.GetFocusedRowCellValue("Surname");
                string _surname = CellValueSurname.ToString();
                object CellValueDateStart = gridEmployees.GetFocusedRowCellValue("DateStart");
              DateTime _dateStart = (DateTime)CellValueDateStart;
                String _dateStartt = _dateStart.ToString("d");
              // DateTime _dateStart = DateTime.ParseExact(CellValueDateStart.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
              //_dateStart = DateTime.Now.ToString("dd/MM/yyyy").Replace('-', '/');
              //string s = _dateStart.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                object CellValueDateEnd = gridEmployees.GetFocusedRowCellValue("DateEnd");
                DateTime _dateEnd = (DateTime)CellValueDateEnd;
                String _dateEndd = _dateEnd.ToString("d");
                //string dateEnd = $"{_dateEnd.Year}{_dateEnd.Month}{_dateEnd.Day}";

                object CellValueSalary = gridEmployees.GetFocusedRowCellValue("Salary");
                decimal _salary = (decimal)CellValueSalary;
                String _salaryy = _salary.ToString();
                _salaryy = _salaryy.Replace(",", ".");
                ////,DateStart = '" + s + "',[DateEnd] = '" + _dateEnd+"'
                MessageBox.Show(_salaryy); //
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [Employee] SET Surname = '" + _surname + "',[Name] = '" + _name  + "',DateStart = '" + _dateStartt + "',DateEnd = '" + _dateEndd + "',Salary = '" + _salaryy + "' WHERE ID = '" + _id+"'; ", _SqlConnection);

                //SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [Employee] SET Surname = '" + _surname + "',[Name] = '" + _name + "',DateStart = '" + _dateStartt + "',[DateEnd] = '" + _dateEndd +  "' WHERE ID = '"+ _id+"'; ", _SqlConnection);
                //      SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [Employee] SET Surname = '" + _surname + "',[Name] = '" + _name + "',[Salary] = '"+ _salary +        "' WHERE ID = '"+ _id+"'; ", _SqlConnection);

                //adapter.Fill(MasterData);
                
            }
            catch (Exception ex) {
                
                MessageBox.Show("Fail");
            }

        }
        //GetItemData
        private void GetItemData() {
            gridControl1.MainView = gridItems;
            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Code], [Description], [ItemType], [Price], [Cost] FROM [Items]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
            gridControl1.DataSource = MasterData.Tables[0];
        }
        //DeleteItems
        private void DeleteItems() {

            try {

                object CellValue = gridItems.GetFocusedRowCellValue("ID");
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

                object CellValueID = gridItems.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValueID;
                MessageBox.Show(_id.ToString());
                object CellValueCode = gridItems.GetFocusedRowCellValue("Code");
                string _code = CellValueCode.ToString();
                object CellValueDescription = gridItems.GetFocusedRowCellValue("Description");
                string _description = CellValueDescription.ToString();
                object CellValueItemType = gridItems.GetFocusedRowCellValue("ItemType");
                string _itemType = CellValueItemType.ToString();
                object CellValuePrice = gridItems.GetFocusedRowCellValue("Price");
                decimal _price = (decimal)CellValuePrice;
                object CellValueCost = gridItems.GetFocusedRowCellValue("Cost");
                decimal _cost = (decimal)CellValueCost;

             
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Items SET Code = '" + _code + "',[Description] = '" + _description + "',ItemType = '" + _itemType + "',[Price] = " + _price+",[Cost] = "+ _cost + " WHERE ID = '" + _id + "'; ", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }

        }
        //GetTransactionData
        private void GetTransactionData() {
            gridControl1.MainView = gridTransactions;
            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Date], [CustomerID], [DiscountValue], [TotalValue] FROM [Transaction]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
            gridControl1.DataSource = MasterData.Tables[0];

        }
        //DeleteTransaction
        private void DeleteTransaction() {

            try {

                object CellValue = gridTransactions.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Transaction WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }
        //UpdateTransaction
      /*  private void UpdateTransaction() {

            try {


                object CellValueID = gridTransactions.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValueID;
                MessageBox.Show(_id.ToString());
                object CellValueDate = gridTransactions.GetFocusedRowCellValue("Date");
                DateTime _date = (DateTime)CellValueDate;
                object CellValueCustomerID = gridTransactions.GetFocusedRowCellValue("CustomerID");//////////////////////
                Guid _customerID = (Guid)CellValueID;
                object CellValueDiscountValue = gridTransactions.GetFocusedRowCellValue("DiscountValue");
                decimal _discountValue = (decimal)CellValueDiscountValue;
                object CellValueTotalValue = gridTransactions.GetFocusedRowCellValue("TotalValue");
                decimal _totalValue = (decimal)CellValueTotalValue;


                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Transaction SET Date = '" + _date + "',[CustomerID] = '" + _customerID + "',DiscountValue = " + _discountValue + ",[TotalValue] = " + _totalValue +  " WHERE ID = '" + _id + "'; ", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }

        }*/
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

                object CellValue = gridTransactionLine.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM TransactionLine WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }

        //UpdateTransactionLine
        private void UpdateTransactionLine() {

            try {


                object CellValueID = gridTransactionLine.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValueID;
                object CellValueQuantity = gridTransactionLine.GetFocusedRowCellValue("Quantity");
                decimal _quantity = (decimal)CellValueQuantity;
                object CellValueItemPrice = gridTransactionLine.GetFocusedRowCellValue("ItemPrice");
                decimal _itemPrice = (decimal)CellValueItemPrice;



                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE[TransactionLine] SET[Quantity] = " + _quantity + ",[ItemPrice] = " + _itemPrice + "WHERE ID = '" + _id + "'; ", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }


         
        }
        //UpdateTransaction
        private void UpdateTransaction(Guid TransactionId) {

            try {


                object CellValueTransactionId = gridTransactionLine.GetFocusedRowCellValue("TransactionId");
                Guid _id = (Guid)CellValueTransactionId;


                //  decimal _totalValue = (decimal)totalValue;

                //decimal _discountValue = (decimal)discountValue;

                //  SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [Transaction] SET [TotalValue] = " + _totalValue + ", [DiscountValue] = " + _discountValue + " WHERE ID = '" + _id + "'; ", _SqlConnection);

                //   adapter.Fill(MasterData);

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

                object CellValue = gridLedger.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Ledger WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }

        private void gridCustomers_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {
            UpdateCustomer();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }


        private void getEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetEmployeeData();
        }

        private void gridEmployees_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {
            UpdateEmployee();
        }

        private void addCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddForm addform = new AddForm(new Customer());
            addform.ShowDialog();
           // MessageBox.Show(addform.Type);
        }
    }
}
