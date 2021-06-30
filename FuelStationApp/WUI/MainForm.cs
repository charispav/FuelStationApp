
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
        private DataSet MasterDataOld = new DataSet();
        public EntityTypeEnum EntityType { get; set; }


        public MainForm(SqlConnection sqlConnection) {
            _SqlConnection = sqlConnection;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        #region Events 

        //-------------------Transaction Events-------------------
        private void getTransactions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            GetTransactionData();
        }

        private void openSelectedTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void addTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void saveTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void deleteTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        //-------------------Item Events-------------------
        private void getAllItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetItemData();
        }

        private void addItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void saveItemsChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void deleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        //-------------------Customer Events-------------------
        private void getCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            GetCustomerData();
        }
        private void addCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddCustomer();
        }

        private void saveCustomerChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            UpdateCustomer();
        }
        private void saveCustomersChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            UpdateEntry("ID");
        }
        private void deleteCustomer2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DeleteCustomer();
        }

        //-------------------Employee Events-------------------
        private void getEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetEmployeeData();
        }

        private void addEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void saveEmployeesChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void deleteEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }
        //-------------------Ledger Events-------------------

        private void showLedger_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        //-------------------Transaction Line Events-------------------
        private void getTransactionLines_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void getCustomerDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void addTransactionLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void saveTransChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void deleteTransLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }


        #endregion

        #region CRUD Transactions
        private void GetTransactionData() {

            try {
                MasterData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Date], [CustomerID], [DiscountValue], [TotalValue] FROM [Transaction]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
            gridControl1.MainView = gridTransactions;
            gridControl1.DataSource = MasterData.Tables[0];

        }

        //TODO: Add Transaction

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


        #endregion

        #region CRUD Customers
        private void GetCustomerData() {
           
            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID],[Name],[Surname],[CardNumber] FROM CUSTOMERS", _SqlConnection);

                MasterData = new DataSet();
                adapter.Fill(MasterData,"Customers");


            }
            catch (Exception ex) {

            }


            gridControl1.MainView = gridCustomers;
            gridControl1.DataSource = MasterData.Tables[0];

        }

        private void AddCustomer() {
            GetCustomerData();
            int initialLength = MasterData.Tables[0].Rows.Count;
            AddForm addForm = new AddForm(EntityTypeEnum.Customer);
            addForm._MasterData = MasterData;
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK) {
                Guid id = (Guid)MasterData.Tables[0].Rows[initialLength].ItemArray[0];
                string name = Convert.ToString(MasterData.Tables[0].Rows[initialLength].ItemArray[1]);
                string surname = Convert.ToString(MasterData.Tables[0].Rows[initialLength].ItemArray[2]);
                int cardNumber = Convert.ToInt32(MasterData.Tables[0].Rows[initialLength].ItemArray[3]);
                //SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO Customers ([ID],[Name],[Surname],[CardNumber]) VALUES ('" + id + "' ,'" + name + "' ,'" + surname + "' ,"+ cardNumber + ");", _SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter($"INSERT INTO Customers ([ID],[Name],[Surname],[CardNumber]) VALUES ('{id}','{name}','{surname}','{cardNumber}')", _SqlConnection);

                adapter.Fill(MasterData);
            }
        }

        private void UpdateCustomer() {

            try {

                object CellValue = gridCustomers.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;

                object CellValueName = gridCustomers.GetFocusedRowCellValue("Name");
                string _name = CellValueName.ToString();
                object CellValueSurname = gridCustomers.GetFocusedRowCellValue("Surname");
                string _surname = CellValueSurname.ToString();
                object CellValueCardNumber = gridCustomers.GetFocusedRowCellValue("CardNumber");
                int _cardNumber = (int)CellValueCardNumber;

                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Customers SET Surname ='" + _surname + "' ,	[Name] ='" + _name + "' , CardNumber ='" + _cardNumber + "'WHERE ID = '" + _id + "';", _SqlConnection);

                adapter.Fill(MasterData);
                MessageBox.Show("Database Updated!");

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

        }

        #endregion

        #region CRUD Items
        private void GetItemData() {

            try {
                MasterData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Code], [Description], [ItemType], [Price], [Cost] FROM [Items]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
            gridControl1.MainView = gridItems;
            gridControl1.DataSource = MasterData.Tables[0];
        }

        //Additem()

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


                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Items SET Code = '" + _code + "',[Description] = '" + _description + "',ItemType = '" + _itemType + "',[Price] = " + _price + ",[Cost] = " + _cost + " WHERE ID = '" + _id + "'; ", _SqlConnection);

                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }

        }

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


        #endregion

        #region CRUD Employees
        private void GetEmployeeData() {


            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Name], [Surname], [DateStart], [DateEnd], [Salary] FROM [Employee]", _SqlConnection);
                MasterData = new DataSet();
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
            gridControl1.MainView = gridEmployees;
            gridControl1.DataSource = MasterData.Tables[0];
        }

        //AddEmployee

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
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [Employee] SET Surname = '" + _surname + "',[Name] = '" + _name + "',DateStart = '" + _dateStartt + "',DateEnd = '" + _dateEndd + "',Salary = '" + _salaryy + "' WHERE ID = '" + _id + "'; ", _SqlConnection);

                //SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [Employee] SET Surname = '" + _surname + "',[Name] = '" + _name + "',DateStart = '" + _dateStartt + "',[DateEnd] = '" + _dateEndd +  "' WHERE ID = '"+ _id+"'; ", _SqlConnection);
                //      SqlDataAdapter adapter = new SqlDataAdapter("UPDATE [Employee] SET Surname = '" + _surname + "',[Name] = '" + _name + "',[Salary] = '"+ _salary +        "' WHERE ID = '"+ _id+"'; ", _SqlConnection);

                //adapter.Fill(MasterData);

            }
            catch (Exception ex) {

                MessageBox.Show("Fail");
            }

        }

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

        #endregion

        #region CRUD Transaction Lines
        private void GetTransactionLineData() {

            try {
                MasterData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [TransactionId], [ItemID], [Quantity], [ItemPrice], [Value] FROM [TransactionLine]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }

        //TODO: GetTransactionCustomerDetails

        //TODO: AddTransaction Line

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
        #endregion

        #region CRUD Ledger
        private void GetLedgerData() {

            try {
                MasterData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [DateFrom], [DateTo], [Income], [Expences], [Total] FROM [Ledger]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {

            }
        }

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

        #endregion
        private void AppendLog(string name, object message) {
            // txtLog.AppendText(string.Format("{0}={1}{2}", name, message, Environment.NewLine));
        }

        private void UpdateEntry(string primaryKey) {

            List<string> sqlCommands = new List<string>();

            DataTable changes = MasterData.Tables[0].GetChanges();

            bool hasChanges = MasterData.HasChanges();
            if (!hasChanges) {
                return;
            }

            foreach (DataRow row in changes.Rows) {

                string sql = string.Empty;
                string sqlSet = string.Empty;

                List<string> sqlSetLines = new List<string>();
                List<string> sqlWhereLines = new List<string>();

                foreach (DataColumn column in changes.Columns) {

                    if (column.ColumnName == primaryKey) {
                        ComposeQueryField(sqlWhereLines, column.ColumnName, row[column]);
                    }
                    else {

                       // if (row[column.ColumnName].ToString() != rowOld[column.ColumnName].ToString()) {

                            ComposeQueryField(sqlSetLines, column.ColumnName, row[column]);
                      //  }
                    }
                }

                sqlSet = string.Join(",", sqlSetLines);

                if (sqlSetLines.Count > 0) {
                    sql = "UPDATE " + MasterData.Tables[0].TableName + " SET " + sqlSet + " WHERE " + string.Join(",", sqlWhereLines);
                    sqlCommands.Add(sql);
                    
                }
            }
            foreach (string sqlcommand in sqlCommands) {
                SqlCommand command = new SqlCommand(sqlcommand, _SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} row(s) affected");
            }
        }


        private void ComposeQueryField(List<string> sqlLine, string columnName, object value) {

            switch (value.GetType().Name) {
                case "String":
                case "Guid":
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, value));
                    break;

                case "Int32":
                case "Int64":
                    sqlLine.Add(string.Format("{0}={1}", columnName, value));
                    break;
                
                    
                case "DateTime":
                    string datePart = Convert.ToDateTime(value).ToString("yyyyMMdd");
                    sqlLine.Add(string.Format("{0}='{1}'", columnName, datePart));
                    break;

                case "Decimal":

                    // decimal provider , .

                    string decimalPart = Convert.ToDecimal(value).ToString().Replace(',', '.');

                    sqlLine.Add(string.Format("{0}={1}", columnName, decimalPart));
                    break;
            }



        }

        
    }
}
