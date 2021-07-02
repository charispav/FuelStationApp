
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
        public string transactionFocusedRow;
        private void openSelectedTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            transactionFocusedRow = gridTransactions.GetFocusedRowCellValue("ID").ToString();
            gridControl1.MainView = gridTransactionLine;
            ribbonControl1.SelectedPage = actions;
            
        }

        private void addTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetItemData();
            AddTransactionForm addTransactionForm = new AddTransactionForm(MasterData, _SqlConnection);
   

            addTransactionForm.ShowDialog();

        }

        private void saveTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            UpdateEntry("ID");
        }

        private void deleteTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        //-------------------Item Events-------------------
        private void getAllItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetItemData();
        }

        private void addItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddItem();
        }

        private void saveItemsChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            UpdateEntry("ID");
            GetItemData();
        }

        private void deleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DeleteItems();
        }

        //-------------------Customer Events-------------------
        private void getCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            GetCustomerData();
        }
        private void addCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddCustomer();
        }

        private void saveCustomersChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            UpdateEntry("ID");
            GetCustomerData();
        }
        private void deleteCustomer2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DeleteCustomer();
        }

        //-------------------Employee Events-------------------
        private void getEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetEmployeeData();
        }

        private void addEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddEmployee();
        }

        private void saveEmployeesChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            UpdateEntry("ID");
            GetEmployeeData();
        }

        private void deleteEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DeleteEmployee();
        }
        //-------------------Ledger Events-------------------

        private void showLedger_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetLedgerData();
        }

        //-------------------Transaction Line Events-------------------
        private void getTransactionLines_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetTransactionLineData();
            gridControl1.DataSource = MasterData.Tables[0];
        }

        private void getCustomerDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            SqlDataAdapter adapter= new SqlDataAdapter($"SELECT[Name],[Surname],[CardNumber] FROM CUSTOMERS LEFT JOIN[Transaction] ON Customers.ID = [Transaction].CustomerID WHERE[Transaction].ID ='{transactionFocusedRow}' ", _SqlConnection);
            DataSet CustomerDetails = new DataSet();
            adapter.Fill(CustomerDetails);
            MessageBox.Show($"Name: '{CustomerDetails.Tables[0].Rows[0].ItemArray[0].ToString()}' \n Surname: '{CustomerDetails.Tables[0].Rows[0].ItemArray[1].ToString()}' \n Card Number: '{CustomerDetails.Tables[0].Rows[0].ItemArray[2].ToString()}'" );
        }

        private void addTransactionLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void saveTransChanges_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void deleteTransLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DeleteTransactionLine();
            GetTransactionLineData();
            
        }


        #endregion

        #region CRUD Transactions
        private void GetTransactionData() {

            try {
                
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Date], [CustomerID], [DiscountValue], [TotalValue] FROM [Transaction]", _SqlConnection);
                MasterData = new DataSet();
                adapter.Fill(MasterData);

            }
            catch (Exception) {

            }
            gridControl1.MainView = gridTransactions;
            gridControl1.DataSource = MasterData.Tables[0];

        }

        //TODO: Add Transaction


        private void DeleteTransaction() {

            try {

                object CellValue = gridTransactions.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                MessageBox.Show(_id.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Transaction WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception) {

            }
        }


        #endregion

        #region CRUD Customers
        private void GetCustomerData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID],[Name],[Surname],[CardNumber] FROM CUSTOMERS", _SqlConnection);

                MasterData = new DataSet();
                MasterDataOld = new DataSet();
                adapter.Fill(MasterData, "Customers");
                adapter.Fill(MasterDataOld, "Customers");


            }
            catch (Exception) {

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

        

        private void DeleteCustomer() {

            try {

                object CellValue = gridCustomers.GetFocusedRowCellValue("ID");
                Guid _id = (Guid) CellValue;
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Customers WHERE ID = '" + _id + "';", _SqlConnection);

                adapter.Fill(MasterData);
                GetCustomerData();
            }
            catch (Exception) {
                MessageBox.Show("No record selected!");
            }

        }

        #endregion

        #region CRUD Items
        private void GetItemData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Code], [Description], [ItemType], [Price], [Cost] FROM [Items]", _SqlConnection);
                MasterData = new DataSet();
                MasterDataOld = new DataSet();
                adapter.Fill(MasterData, "Items");
                adapter.Fill(MasterDataOld, "Items");
               

            }
            catch (Exception) {

            }
            gridControl1.MainView = gridItems;
            gridControl1.DataSource = MasterData.Tables[0];
        }

        private void AddItem() {
            GetItemData();
            int initialLength = MasterData.Tables[0].Rows.Count;
            AddForm addForm = new AddForm(EntityTypeEnum.Item);
            addForm._MasterData = MasterData;
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK) {
                Guid id = (Guid)MasterData.Tables[0].Rows[initialLength].ItemArray[0];
                string code = Convert.ToString(MasterData.Tables[0].Rows[initialLength].ItemArray[1]);
                string description = Convert.ToString(MasterData.Tables[0].Rows[initialLength].ItemArray[2]);
                string itemType = Convert.ToString(MasterData.Tables[0].Rows[initialLength].ItemArray[3]);
                
                string price = MasterData.Tables[0].Rows[initialLength].ItemArray[4].ToString().Replace(',', '.');
                string cost = MasterData.Tables[0].Rows[initialLength].ItemArray[5].ToString().Replace(',', '.');
                SqlDataAdapter adapter = new SqlDataAdapter($"INSERT INTO Items ([ID],[Code],[Description],[ItemType],[Price],[Cost]) VALUES ('{id}','{code}','{description}','{itemType}','{price}','{cost}')", _SqlConnection);

                adapter.Fill(MasterData);
            }

        }

        private void DeleteItems() {

            try {

                object CellValue = gridItems.GetFocusedRowCellValue("ID");
                Guid _id = (Guid) CellValue;
                
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Items WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception) {
                MessageBox.Show("No record selected!");
            }
            GetItemData();
        }


        #endregion

        #region CRUD Employees
        private void GetEmployeeData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [Name], [Surname], [DateStart], [DateEnd], [Salary] FROM [Employee]", _SqlConnection);
                MasterData = new DataSet();
                MasterDataOld = new DataSet();
                adapter.Fill(MasterData, "Employee");
                adapter.Fill(MasterDataOld, "Employee");

            }
            catch (Exception) {

            }
            gridControl1.MainView = gridEmployees;
            gridControl1.DataSource = MasterData.Tables[0];
        }
        private void AddEmployee() {
            GetEmployeeData();
            int initialLength = MasterData.Tables[0].Rows.Count;
            AddForm addForm = new AddForm(EntityTypeEnum.Employee);
            addForm._MasterData = MasterData;
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK) {
                Guid id = (Guid)MasterData.Tables[0].Rows[initialLength].ItemArray[0];
                string name = Convert.ToString(MasterData.Tables[0].Rows[initialLength].ItemArray[1]);
                string surname = Convert.ToString(MasterData.Tables[0].Rows[initialLength].ItemArray[2]);
                string dateStart = Convert.ToDateTime(MasterData.Tables[0].Rows[initialLength].ItemArray[3]).ToString("yyyyMMdd");
                string dateEnd = Convert.ToDateTime(MasterData.Tables[0].Rows[initialLength].ItemArray[4]).ToString("yyyyMMdd");

                string salary = MasterData.Tables[0].Rows[initialLength].ItemArray[5].ToString().Replace(',', '.');

                SqlDataAdapter adapter = new SqlDataAdapter($"INSERT INTO Employee ([ID],[Name],[Surname],[DateStart],[DateEnd],[Salary]) VALUES ('{id}','{name}','{surname}','{dateStart}','{dateEnd}','{salary}')", _SqlConnection);

                adapter.Fill(MasterData);
            }

        }


        private void DeleteEmployee() {

            try {

                object CellValue = gridEmployees.GetFocusedRowCellValue("ID");
                Guid _id = (Guid) CellValue;
            
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Employee WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);
                GetEmployeeData();
            }
            catch (Exception) {
                MessageBox.Show("No record selected!");
            }
        }

        #endregion

        #region CRUD Transaction Lines
        private void GetTransactionLineData() {

            try {

              
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT [ID], [TransactionId], [ItemID], [Quantity], [ItemPrice], [Value] FROM [TransactionLine] WHERE TransactionId='{transactionFocusedRow}'", _SqlConnection);

                MasterData = new DataSet();
                MasterDataOld = new DataSet();
                adapter.Fill(MasterData, "TransactionLine");
                adapter.Fill(MasterDataOld, "TransactionLine");

            }
            catch (Exception) {

            }
            gridControl1.MainView = gridTransactionLine;
            gridControl1.DataSource = MasterData.Tables[0];
        }

        //TODO: GetTransactionCustomerDetails

        //TODO: AddTransaction Line



        private void DeleteTransactionLine() {

            try {

                object CellValue = gridTransactionLine.GetFocusedRowCellValue("ID");
                Guid _id = (Guid)CellValue;
                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM TransactionLine WHERE ID = '" + _id + "';", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception) {

            }
        }
        #endregion

        #region CRUD Ledger
        private void GetLedgerData() {
            //GetEmployeeData();
            // int initialLength = MasterData.Tables[0].Rows.Count;
            AddForm addForm = new AddForm(EntityTypeEnum.Ledger);
            addForm._MasterData = MasterData;
            addForm.ShowDialog();


            try {
                MasterData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [ID], [DateFrom], [DateTo], [Income], [Expences], [Total] FROM [Ledger]", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception) {

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
            catch (Exception) {

            }
        }

        #endregion


        private void UpdateEntry(string primaryKey) {
            try {


                List<string> sqlCommands = new List<string>();


                bool hasChanges = MasterData.HasChanges();
                if (!hasChanges) {
                    return;
                }

                foreach (DataRow row in MasterData.Tables[0].Rows) {

                    string sql = string.Empty;
                    string sqlSet = string.Empty;

                    List<string> sqlSetLines = new List<string>();
                    List<string> sqlWhereLines = new List<string>();

                    DataRow rowOld = MasterDataOld.Tables[0].Select(String.Format("ID='{0}'", row[primaryKey].ToString()))[0];


                    foreach (DataColumn column in MasterData.Tables[0].Columns) {

                        if (column.ColumnName == primaryKey) {
                            ComposeQueryField(sqlWhereLines, column.ColumnName, row[column]);
                        }
                        else {

                            if (row[column.ColumnName].ToString() != rowOld[column.ColumnName].ToString()) {

                                ComposeQueryField(sqlSetLines, column.ColumnName, row[column]);
                            }
                        }
                    }

                    sqlSet = string.Join(",", sqlSetLines);

                    if (sqlSetLines.Count > 0) {
                        sql = "UPDATE " + MasterData.Tables[0].TableName + " SET " + sqlSet + " WHERE " + string.Join(",", sqlWhereLines);
                        sqlCommands.Add(sql);

                    }
                }
                int totalRowsAffected = 0;
                foreach (string sqlcommand in sqlCommands) {

                    SqlCommand command = new SqlCommand(sqlcommand, _SqlConnection);
                    int rowsAffected = command.ExecuteNonQuery();
                    totalRowsAffected += rowsAffected;

                }
                MessageBox.Show($"{totalRowsAffected} row(s) affected");
            }
            catch (Exception) {
                MessageBox.Show("Already up to date!");
                
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

                    string decimalPart = Convert.ToDecimal(value).ToString().Replace(',', '.');

                    sqlLine.Add(string.Format("{0}={1}", columnName, decimalPart));
                    break;
                case "ItemTypeEnum":
                    ItemTypeEnum enumVal = (ItemTypeEnum)value;
                    sqlLine.Add(string.Format("{0}={1}", columnName, Convert.ToInt16(enumVal)));
                    break;
            }



        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void gridControl1_Load(object sender, EventArgs e) {
            
        }
    }
}
