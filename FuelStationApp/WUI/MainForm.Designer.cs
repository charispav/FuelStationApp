
namespace FuelStationApp {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.getTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.deleteTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.addCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.getCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.deleteCustomer2 = new DevExpress.XtraBars.BarButtonItem();
            this.getEmployees = new DevExpress.XtraBars.BarButtonItem();
            this.addEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.deleteEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.showLedger = new DevExpress.XtraBars.BarButtonItem();
            this.getAllItems = new DevExpress.XtraBars.BarButtonItem();
            this.addItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteItem = new DevExpress.XtraBars.BarButtonItem();
            this.openSelectedTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.getTransactionLines = new DevExpress.XtraBars.BarButtonItem();
            this.saveTransactionChanges = new DevExpress.XtraBars.BarButtonItem();
            this.saveItemChanges = new DevExpress.XtraBars.BarButtonItem();
            this.saveCustomerChanges = new DevExpress.XtraBars.BarButtonItem();
            this.saveEmployeeChanges = new DevExpress.XtraBars.BarButtonItem();
            this.saveTransChanges = new DevExpress.XtraBars.BarButtonItem();
            this.addTransactionLine = new DevExpress.XtraBars.BarButtonItem();
            this.deleteTransLine = new DevExpress.XtraBars.BarButtonItem();
            this.getCustomerDetails = new DevExpress.XtraBars.BarButtonItem();
            this.saveCustomersChanges = new DevExpress.XtraBars.BarButtonItem();
            this.saveTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.saveItemsChanges = new DevExpress.XtraBars.BarButtonItem();
            this.saveEmployeesChanges = new DevExpress.XtraBars.BarButtonItem();
            this.transactionCategory = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.actions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.viewAndEditTransactionLinesPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.modifyTL = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveTLPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deleteTLPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.transactions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ViewAndEditTransactions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.modifyTransaction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveTransactionChangesPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deleteTransactionPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.items = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.viewAndEditItems = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.modifyItems = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveItemsChangesPG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deleteItemPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.customers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.viewAndEditCustomers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.modifyCustomer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveCustomerPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deleteCustomerPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.employees = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.viewAndEditEmployees = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.modifyEmployee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveEmployeePG = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deleteEmployeePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ledger = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.viewLedger = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ribbonStatusBar2 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fuelStationDBDataSet = new FuelStationApp.FuelStationDBDataSet();
            this.fuelStationDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEnum = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridLedger = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDLedger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Income = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Expenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Surname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDTransactionLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemiD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.addTransaction,
            this.getTransactions,
            this.deleteTransaction,
            this.addCustomer,
            this.getCustomers,
            this.deleteCustomer2,
            this.getEmployees,
            this.addEmployee,
            this.deleteEmployee,
            this.showLedger,
            this.getAllItems,
            this.addItem,
            this.deleteItem,
            this.openSelectedTransaction,
            this.getTransactionLines,
            this.saveTransactionChanges,
            this.saveItemChanges,
            this.saveCustomerChanges,
            this.saveEmployeeChanges,
            this.saveTransChanges,
            this.addTransactionLine,
            this.deleteTransLine,
            this.getCustomerDetails,
            this.saveCustomersChanges,
            this.saveTransaction,
            this.saveItemsChanges,
            this.saveEmployeesChanges});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 38;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.transactionCategory});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.transactions,
            this.items,
            this.customers,
            this.employees,
            this.ledger});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(996, 195);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar2;
            // 
            // addTransaction
            // 
            this.addTransaction.Caption = "Add New Transaction";
            this.addTransaction.Id = 9;
            this.addTransaction.ImageOptions.Image = global::FuelStationApp.Resources.add_16x161;
            this.addTransaction.ImageOptions.LargeImage = global::FuelStationApp.Resources.add_32x321;
            this.addTransaction.Name = "addTransaction";
            this.addTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addTransaction_ItemClick);
            // 
            // getTransactions
            // 
            this.getTransactions.Caption = "Get All Transactions";
            this.getTransactions.Id = 10;
            this.getTransactions.ImageOptions.Image = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_16x16;
            this.getTransactions.ImageOptions.LargeImage = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_32x32;
            this.getTransactions.Name = "getTransactions";
            this.getTransactions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getTransactions_ItemClick);
            // 
            // deleteTransaction
            // 
            this.deleteTransaction.Caption = "Delete Transaction";
            this.deleteTransaction.Id = 12;
            this.deleteTransaction.ImageOptions.Image = global::FuelStationApp.Resources.delete_16x16;
            this.deleteTransaction.ImageOptions.LargeImage = global::FuelStationApp.Resources.delete_32x32;
            this.deleteTransaction.Name = "deleteTransaction";
            this.deleteTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteTransaction_ItemClick);
            // 
            // addCustomer
            // 
            this.addCustomer.Caption = "Add New Customer";
            this.addCustomer.Id = 13;
            this.addCustomer.ImageOptions.Image = global::FuelStationApp.Resources.add_16x162;
            this.addCustomer.ImageOptions.LargeImage = global::FuelStationApp.Resources.add_32x322;
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCustomer_ItemClick);
            // 
            // getCustomers
            // 
            this.getCustomers.Caption = "Get All Customers";
            this.getCustomers.Id = 15;
            this.getCustomers.ImageOptions.Image = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_16x161;
            this.getCustomers.ImageOptions.LargeImage = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_32x321;
            this.getCustomers.Name = "getCustomers";
            this.getCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getCustomers_ItemClick);
            // 
            // deleteCustomer2
            // 
            this.deleteCustomer2.Caption = "Delete Customer";
            this.deleteCustomer2.Id = 16;
            this.deleteCustomer2.ImageOptions.Image = global::FuelStationApp.Resources.delete_16x161;
            this.deleteCustomer2.ImageOptions.LargeImage = global::FuelStationApp.Resources.delete_32x321;
            this.deleteCustomer2.Name = "deleteCustomer2";
            this.deleteCustomer2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteCustomer2_ItemClick);
            // 
            // getEmployees
            // 
            this.getEmployees.Caption = "Get All Employees";
            this.getEmployees.Id = 17;
            this.getEmployees.ImageOptions.Image = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_16x162;
            this.getEmployees.ImageOptions.LargeImage = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_32x322;
            this.getEmployees.Name = "getEmployees";
            this.getEmployees.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getEmployees_ItemClick);
            // 
            // addEmployee
            // 
            this.addEmployee.Caption = "Add New Employee";
            this.addEmployee.Id = 18;
            this.addEmployee.ImageOptions.Image = global::FuelStationApp.Resources.add_16x163;
            this.addEmployee.ImageOptions.LargeImage = global::FuelStationApp.Resources.add_32x323;
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addEmployee_ItemClick);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Caption = "Delete Employee";
            this.deleteEmployee.Id = 19;
            this.deleteEmployee.ImageOptions.Image = global::FuelStationApp.Resources.delete_16x162;
            this.deleteEmployee.ImageOptions.LargeImage = global::FuelStationApp.Resources.delete_32x322;
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteEmployee_ItemClick);
            // 
            // showLedger
            // 
            this.showLedger.Caption = "Show Ledger";
            this.showLedger.Id = 20;
            this.showLedger.ImageOptions.Image = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_16x163;
            this.showLedger.ImageOptions.LargeImage = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_32x323;
            this.showLedger.Name = "showLedger";
            this.showLedger.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showLedger_ItemClick);
            // 
            // getAllItems
            // 
            this.getAllItems.Caption = "Get All Items";
            this.getAllItems.Id = 21;
            this.getAllItems.ImageOptions.Image = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_16x164;
            this.getAllItems.ImageOptions.LargeImage = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_32x324;
            this.getAllItems.Name = "getAllItems";
            this.getAllItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getAllItems_ItemClick);
            // 
            // addItem
            // 
            this.addItem.Caption = "Add New Item";
            this.addItem.Id = 22;
            this.addItem.ImageOptions.Image = global::FuelStationApp.Resources.add_16x164;
            this.addItem.ImageOptions.LargeImage = global::FuelStationApp.Resources.add_32x324;
            this.addItem.Name = "addItem";
            this.addItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addItem_ItemClick);
            // 
            // deleteItem
            // 
            this.deleteItem.Caption = "Delete Item";
            this.deleteItem.Id = 23;
            this.deleteItem.ImageOptions.Image = global::FuelStationApp.Resources.delete_16x163;
            this.deleteItem.ImageOptions.LargeImage = global::FuelStationApp.Resources.delete_32x323;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteItem_ItemClick);
            // 
            // openSelectedTransaction
            // 
            this.openSelectedTransaction.Caption = "Open Selected Transaction";
            this.openSelectedTransaction.Id = 24;
            this.openSelectedTransaction.ImageOptions.Image = global::FuelStationApp.Resources.open_16x16;
            this.openSelectedTransaction.ImageOptions.LargeImage = global::FuelStationApp.Resources.open_32x32;
            this.openSelectedTransaction.Name = "openSelectedTransaction";
            this.openSelectedTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openSelectedTransaction_ItemClick);
            // 
            // getTransactionLines
            // 
            this.getTransactionLines.Caption = "Get Transaction Lines";
            this.getTransactionLines.Id = 25;
            this.getTransactionLines.ImageOptions.Image = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_16x165;
            this.getTransactionLines.ImageOptions.LargeImage = global::FuelStationApp.Resources.showallsubtotalsattoppivottable_32x325;
            this.getTransactionLines.Name = "getTransactionLines";
            this.getTransactionLines.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getTransactionLines_ItemClick);
            // 
            // saveTransactionChanges
            // 
            this.saveTransactionChanges.Caption = "Save Changes";
            this.saveTransactionChanges.Id = 26;
            this.saveTransactionChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x16;
            this.saveTransactionChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x32;
            this.saveTransactionChanges.Name = "saveTransactionChanges";
            // 
            // saveItemChanges
            // 
            this.saveItemChanges.Caption = "Save Changes";
            this.saveItemChanges.Id = 27;
            this.saveItemChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x161;
            this.saveItemChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x321;
            this.saveItemChanges.Name = "saveItemChanges";
            // 
            // saveCustomerChanges
            // 
            this.saveCustomerChanges.Caption = "Save Changes";
            this.saveCustomerChanges.Id = 28;
            this.saveCustomerChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x162;
            this.saveCustomerChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x322;
            this.saveCustomerChanges.Name = "saveCustomerChanges";
            // 
            // saveEmployeeChanges
            // 
            this.saveEmployeeChanges.Caption = "Save Changes";
            this.saveEmployeeChanges.Id = 29;
            this.saveEmployeeChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x163;
            this.saveEmployeeChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x323;
            this.saveEmployeeChanges.Name = "saveEmployeeChanges";
            // 
            // saveTransChanges
            // 
            this.saveTransChanges.Caption = "Save Changes";
            this.saveTransChanges.Id = 30;
            this.saveTransChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x164;
            this.saveTransChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x324;
            this.saveTransChanges.Name = "saveTransChanges";
            this.saveTransChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveTransChanges_ItemClick);
            // 
            // addTransactionLine
            // 
            this.addTransactionLine.Caption = "Add Transaction Line";
            this.addTransactionLine.Id = 31;
            this.addTransactionLine.ImageOptions.Image = global::FuelStationApp.Resources.add_16x165;
            this.addTransactionLine.ImageOptions.LargeImage = global::FuelStationApp.Resources.add_32x325;
            this.addTransactionLine.Name = "addTransactionLine";
            this.addTransactionLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addTransactionLine_ItemClick);
            // 
            // deleteTransLine
            // 
            this.deleteTransLine.Caption = "Delete Transaction Line";
            this.deleteTransLine.Id = 32;
            this.deleteTransLine.ImageOptions.Image = global::FuelStationApp.Resources.delete_16x164;
            this.deleteTransLine.ImageOptions.LargeImage = global::FuelStationApp.Resources.delete_32x324;
            this.deleteTransLine.Name = "deleteTransLine";
            this.deleteTransLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteTransLine_ItemClick);
            // 
            // getCustomerDetails
            // 
            this.getCustomerDetails.Caption = "Get Customer Details";
            this.getCustomerDetails.Id = 33;
            this.getCustomerDetails.ImageOptions.Image = global::FuelStationApp.Resources.showproduct_16x161;
            this.getCustomerDetails.ImageOptions.LargeImage = global::FuelStationApp.Resources.showproduct_32x321;
            this.getCustomerDetails.Name = "getCustomerDetails";
            this.getCustomerDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getCustomerDetails_ItemClick);
            // 
            // saveCustomersChanges
            // 
            this.saveCustomersChanges.Caption = "Save Changes";
            this.saveCustomersChanges.Id = 34;
            this.saveCustomersChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x165;
            this.saveCustomersChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x325;
            this.saveCustomersChanges.Name = "saveCustomersChanges";
            this.saveCustomersChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveCustomersChanges_ItemClick);
            // 
            // saveTransaction
            // 
            this.saveTransaction.Caption = "Save Changes";
            this.saveTransaction.Id = 35;
            this.saveTransaction.ImageOptions.Image = global::FuelStationApp.Resources.save_16x166;
            this.saveTransaction.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x326;
            this.saveTransaction.Name = "saveTransaction";
            this.saveTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveTransaction_ItemClick);
            // 
            // saveItemsChanges
            // 
            this.saveItemsChanges.Caption = "Save Changes";
            this.saveItemsChanges.Id = 36;
            this.saveItemsChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x167;
            this.saveItemsChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x327;
            this.saveItemsChanges.Name = "saveItemsChanges";
            this.saveItemsChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveItemsChanges_ItemClick);
            // 
            // saveEmployeesChanges
            // 
            this.saveEmployeesChanges.Caption = "Save Changes";
            this.saveEmployeesChanges.Id = 37;
            this.saveEmployeesChanges.ImageOptions.Image = global::FuelStationApp.Resources.save_16x168;
            this.saveEmployeesChanges.ImageOptions.LargeImage = global::FuelStationApp.Resources.save_32x328;
            this.saveEmployeesChanges.Name = "saveEmployeesChanges";
            this.saveEmployeesChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveEmployeesChanges_ItemClick);
            // 
            // transactionCategory
            // 
            this.transactionCategory.Name = "transactionCategory";
            this.transactionCategory.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.actions});
            this.transactionCategory.Text = "Transaction";
            // 
            // actions
            // 
            this.actions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.viewAndEditTransactionLinesPageGroup,
            this.modifyTL,
            this.saveTLPageGroup,
            this.deleteTLPageGroup});
            this.actions.Name = "actions";
            this.actions.Text = "Actions";
            // 
            // viewAndEditTransactionLinesPageGroup
            // 
            this.viewAndEditTransactionLinesPageGroup.ItemLinks.Add(this.getTransactionLines);
            this.viewAndEditTransactionLinesPageGroup.ItemLinks.Add(this.getCustomerDetails);
            this.viewAndEditTransactionLinesPageGroup.Name = "viewAndEditTransactionLinesPageGroup";
            this.viewAndEditTransactionLinesPageGroup.Text = "View + Edit";
            // 
            // modifyTL
            // 
            this.modifyTL.ItemLinks.Add(this.addTransactionLine);
            this.modifyTL.Name = "modifyTL";
            this.modifyTL.Text = "Modify";
            // 
            // saveTLPageGroup
            // 
            this.saveTLPageGroup.ItemLinks.Add(this.saveTransChanges);
            this.saveTLPageGroup.Name = "saveTLPageGroup";
            this.saveTLPageGroup.Text = "Save";
            // 
            // deleteTLPageGroup
            // 
            this.deleteTLPageGroup.ItemLinks.Add(this.deleteTransLine);
            this.deleteTLPageGroup.Name = "deleteTLPageGroup";
            this.deleteTLPageGroup.Text = "Delete";
            // 
            // transactions
            // 
            this.transactions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ViewAndEditTransactions,
            this.modifyTransaction,
            this.saveTransactionChangesPG,
            this.deleteTransactionPageGroup});
            this.transactions.Name = "transactions";
            this.transactions.Text = "Transactions";
            // 
            // ViewAndEditTransactions
            // 
            this.ViewAndEditTransactions.ItemLinks.Add(this.getTransactions);
            this.ViewAndEditTransactions.ItemLinks.Add(this.openSelectedTransaction);
            this.ViewAndEditTransactions.Name = "ViewAndEditTransactions";
            this.ViewAndEditTransactions.Text = "View + Edit";
            // 
            // modifyTransaction
            // 
            this.modifyTransaction.ItemLinks.Add(this.addTransaction);
            this.modifyTransaction.Name = "modifyTransaction";
            this.modifyTransaction.Text = "Modify";
            // 
            // saveTransactionChangesPG
            // 
            this.saveTransactionChangesPG.ItemLinks.Add(this.saveTransaction);
            this.saveTransactionChangesPG.Name = "saveTransactionChangesPG";
            this.saveTransactionChangesPG.Text = "Save";
            // 
            // deleteTransactionPageGroup
            // 
            this.deleteTransactionPageGroup.ItemLinks.Add(this.deleteTransaction);
            this.deleteTransactionPageGroup.Name = "deleteTransactionPageGroup";
            this.deleteTransactionPageGroup.Text = "Delete";
            // 
            // items
            // 
            this.items.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.viewAndEditItems,
            this.modifyItems,
            this.saveItemsChangesPG,
            this.deleteItemPageGroup});
            this.items.Name = "items";
            this.items.Text = "Items";
            // 
            // viewAndEditItems
            // 
            this.viewAndEditItems.AllowTextClipping = false;
            this.viewAndEditItems.ItemLinks.Add(this.getAllItems);
            this.viewAndEditItems.Name = "viewAndEditItems";
            this.viewAndEditItems.Text = "View + Edit";
            // 
            // modifyItems
            // 
            this.modifyItems.ItemLinks.Add(this.addItem);
            this.modifyItems.Name = "modifyItems";
            this.modifyItems.Text = "Modify";
            // 
            // saveItemsChangesPG
            // 
            this.saveItemsChangesPG.ItemLinks.Add(this.saveItemsChanges);
            this.saveItemsChangesPG.Name = "saveItemsChangesPG";
            this.saveItemsChangesPG.Text = "Save";
            // 
            // deleteItemPageGroup
            // 
            this.deleteItemPageGroup.ItemLinks.Add(this.deleteItem);
            this.deleteItemPageGroup.Name = "deleteItemPageGroup";
            this.deleteItemPageGroup.Text = "Delete";
            // 
            // customers
            // 
            this.customers.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.viewAndEditCustomers,
            this.modifyCustomer,
            this.saveCustomerPageGroup,
            this.deleteCustomerPageGroup});
            this.customers.Name = "customers";
            this.customers.Text = "Customers";
            // 
            // viewAndEditCustomers
            // 
            this.viewAndEditCustomers.ItemLinks.Add(this.getCustomers);
            this.viewAndEditCustomers.Name = "viewAndEditCustomers";
            this.viewAndEditCustomers.Text = "View + Edit";
            // 
            // modifyCustomer
            // 
            this.modifyCustomer.ItemLinks.Add(this.addCustomer);
            this.modifyCustomer.Name = "modifyCustomer";
            this.modifyCustomer.Text = "Modify";
            // 
            // saveCustomerPageGroup
            // 
            this.saveCustomerPageGroup.ItemLinks.Add(this.saveCustomersChanges);
            this.saveCustomerPageGroup.Name = "saveCustomerPageGroup";
            this.saveCustomerPageGroup.Text = "Save";
            // 
            // deleteCustomerPageGroup
            // 
            this.deleteCustomerPageGroup.ItemLinks.Add(this.deleteCustomer2);
            this.deleteCustomerPageGroup.Name = "deleteCustomerPageGroup";
            this.deleteCustomerPageGroup.Text = "Delete";
            // 
            // employees
            // 
            this.employees.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.viewAndEditEmployees,
            this.modifyEmployee,
            this.saveEmployeePG,
            this.deleteEmployeePageGroup});
            this.employees.Name = "employees";
            this.employees.Text = "Employees";
            // 
            // viewAndEditEmployees
            // 
            this.viewAndEditEmployees.ItemLinks.Add(this.getEmployees);
            this.viewAndEditEmployees.Name = "viewAndEditEmployees";
            this.viewAndEditEmployees.Text = "View + Edit";
            // 
            // modifyEmployee
            // 
            this.modifyEmployee.ItemLinks.Add(this.addEmployee);
            this.modifyEmployee.Name = "modifyEmployee";
            this.modifyEmployee.Text = "Modify";
            // 
            // saveEmployeePG
            // 
            this.saveEmployeePG.ItemLinks.Add(this.saveEmployeesChanges);
            this.saveEmployeePG.Name = "saveEmployeePG";
            this.saveEmployeePG.Text = "Save";
            // 
            // deleteEmployeePageGroup
            // 
            this.deleteEmployeePageGroup.ItemLinks.Add(this.deleteEmployee);
            this.deleteEmployeePageGroup.Name = "deleteEmployeePageGroup";
            this.deleteEmployeePageGroup.Text = "Delete";
            // 
            // ledger
            // 
            this.ledger.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.viewLedger});
            this.ledger.Name = "ledger";
            this.ledger.Text = "Ledger";
            // 
            // viewLedger
            // 
            this.viewLedger.ItemLinks.Add(this.showLedger);
            this.viewLedger.Name = "viewLedger";
            this.viewLedger.Text = "View";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ribbonStatusBar2
            // 
            this.ribbonStatusBar2.Location = new System.Drawing.Point(0, 559);
            this.ribbonStatusBar2.Name = "ribbonStatusBar2";
            this.ribbonStatusBar2.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar2.Size = new System.Drawing.Size(996, 30);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // fuelStationDBDataSet
            // 
            this.fuelStationDBDataSet.DataSetName = "FuelStationDBDataSet";
            this.fuelStationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fuelStationDBDataSetBindingSource
            // 
            this.fuelStationDBDataSetBindingSource.DataSource = this.fuelStationDBDataSet;
            this.fuelStationDBDataSetBindingSource.Position = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gridControl1.Location = new System.Drawing.Point(0, 195);
            this.gridControl1.MainView = this.gridItems;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDateEdit,
            this.repEnum});
            this.gridControl1.Size = new System.Drawing.Size(996, 364);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridItems,
            this.gridLedger,
            this.gridTransactions,
            this.gridCustomers,
            this.gridEmployees,
            this.gridTransactionLine});
            // 
            // gridItems
            // 
            this.gridItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDItem,
            this.Code,
            this.Description,
            this.ItemType,
            this.Price,
            this.Cost});
            this.gridItems.GridControl = this.gridControl1;
            this.gridItems.Name = "gridItems";
            this.gridItems.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // IDItem
            // 
            this.IDItem.Caption = "ID";
            this.IDItem.FieldName = "IDItem";
            this.IDItem.MinWidth = 25;
            this.IDItem.Name = "IDItem";
            this.IDItem.Width = 94;
            // 
            // Code
            // 
            this.Code.Caption = "Code";
            this.Code.FieldName = "Code";
            this.Code.MinWidth = 25;
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 0;
            this.Code.Width = 94;
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 25;
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 1;
            this.Description.Width = 94;
            // 
            // ItemType
            // 
            this.ItemType.Caption = "Item Type";
            this.ItemType.ColumnEdit = this.repEnum;
            this.ItemType.FieldName = "ItemTypeEnum";
            this.ItemType.MinWidth = 25;
            this.ItemType.Name = "ItemType";
            this.ItemType.Visible = true;
            this.ItemType.VisibleIndex = 2;
            this.ItemType.Width = 94;
            // 
            // repEnum
            // 
            this.repEnum.AutoHeight = false;
            this.repEnum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnum.Items.AddRange(new object[] {
            "Fuel",
            "Product",
            "Service"});
            this.repEnum.Name = "repEnum";
            this.repEnum.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // Price
            // 
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 25;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            this.Price.Width = 94;
            // 
            // Cost
            // 
            this.Cost.Caption = "Cost";
            this.Cost.FieldName = "Cost";
            this.Cost.MinWidth = 25;
            this.Cost.Name = "Cost";
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 4;
            this.Cost.Width = 94;
            // 
            // repDateEdit
            // 
            this.repDateEdit.AutoHeight = false;
            this.repDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateEdit.Name = "repDateEdit";
            // 
            // gridLedger
            // 
            this.gridLedger.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDLedger,
            this.DateFrom,
            this.DateTo,
            this.Income,
            this.Expenses,
            this.Total});
            this.gridLedger.GridControl = this.gridControl1;
            this.gridLedger.Name = "gridLedger";
            this.gridLedger.OptionsBehavior.Editable = false;
            // 
            // IDLedger
            // 
            this.IDLedger.Caption = "ID";
            this.IDLedger.FieldName = "ID";
            this.IDLedger.MinWidth = 25;
            this.IDLedger.Name = "IDLedger";
            this.IDLedger.Width = 94;
            // 
            // DateFrom
            // 
            this.DateFrom.Caption = "Date From";
            this.DateFrom.ColumnEdit = this.repDateEdit;
            this.DateFrom.FieldName = "DateFrom";
            this.DateFrom.MinWidth = 25;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Visible = true;
            this.DateFrom.VisibleIndex = 0;
            this.DateFrom.Width = 94;
            // 
            // DateTo
            // 
            this.DateTo.Caption = "Date To";
            this.DateTo.ColumnEdit = this.repDateEdit;
            this.DateTo.FieldName = "DateTo";
            this.DateTo.MinWidth = 25;
            this.DateTo.Name = "DateTo";
            this.DateTo.Visible = true;
            this.DateTo.VisibleIndex = 1;
            this.DateTo.Width = 94;
            // 
            // Income
            // 
            this.Income.Caption = "Income";
            this.Income.FieldName = "Income";
            this.Income.MinWidth = 25;
            this.Income.Name = "Income";
            this.Income.OptionsColumn.ReadOnly = true;
            this.Income.Visible = true;
            this.Income.VisibleIndex = 2;
            this.Income.Width = 94;
            // 
            // Expenses
            // 
            this.Expenses.Caption = "Expenses";
            this.Expenses.FieldName = "Expenses";
            this.Expenses.MinWidth = 25;
            this.Expenses.Name = "Expenses";
            this.Expenses.OptionsColumn.ReadOnly = true;
            this.Expenses.Visible = true;
            this.Expenses.VisibleIndex = 3;
            this.Expenses.Width = 94;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.MinWidth = 25;
            this.Total.Name = "Total";
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 4;
            this.Total.Width = 94;
            // 
            // gridTransactions
            // 
            this.gridTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDTransaction,
            this.Date,
            this.DiscountValue,
            this.TotalValue});
            this.gridTransactions.GridControl = this.gridControl1;
            this.gridTransactions.Name = "gridTransactions";
            this.gridTransactions.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // IDTransaction
            // 
            this.IDTransaction.Caption = "ID";
            this.IDTransaction.FieldName = "ID";
            this.IDTransaction.MinWidth = 25;
            this.IDTransaction.Name = "IDTransaction";
            this.IDTransaction.Width = 94;
            // 
            // Date
            // 
            this.Date.Caption = "Date";
            this.Date.ColumnEdit = this.repDateEdit;
            this.Date.FieldName = "Date";
            this.Date.MinWidth = 25;
            this.Date.Name = "Date";
            this.Date.Visible = true;
            this.Date.VisibleIndex = 0;
            this.Date.Width = 94;
            // 
            // DiscountValue
            // 
            this.DiscountValue.Caption = "Discount Value";
            this.DiscountValue.FieldName = "DiscountValue";
            this.DiscountValue.MinWidth = 25;
            this.DiscountValue.Name = "DiscountValue";
            this.DiscountValue.Visible = true;
            this.DiscountValue.VisibleIndex = 1;
            this.DiscountValue.Width = 94;
            // 
            // TotalValue
            // 
            this.TotalValue.Caption = "Total Value";
            this.TotalValue.FieldName = "TotalValue";
            this.TotalValue.MinWidth = 25;
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Visible = true;
            this.TotalValue.VisibleIndex = 2;
            this.TotalValue.Width = 94;
            // 
            // gridCustomers
            // 
            this.gridCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCustomer,
            this.CustomerName,
            this.Surname,
            this.CardNumber});
            this.gridCustomers.GridControl = this.gridControl1;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // IDCustomer
            // 
            this.IDCustomer.Caption = "ID";
            this.IDCustomer.FieldName = "ID";
            this.IDCustomer.MinWidth = 25;
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.Width = 94;
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "Name";
            this.CustomerName.FieldName = "Name";
            this.CustomerName.MinWidth = 25;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 0;
            this.CustomerName.Width = 94;
            // 
            // Surname
            // 
            this.Surname.Caption = "Surname";
            this.Surname.FieldName = "Surname";
            this.Surname.MinWidth = 25;
            this.Surname.Name = "Surname";
            this.Surname.Visible = true;
            this.Surname.VisibleIndex = 1;
            this.Surname.Width = 94;
            // 
            // CardNumber
            // 
            this.CardNumber.Caption = "Card Number";
            this.CardNumber.FieldName = "CardNumber";
            this.CardNumber.MinWidth = 25;
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Visible = true;
            this.CardNumber.VisibleIndex = 2;
            this.CardNumber.Width = 94;
            // 
            // gridEmployees
            // 
            this.gridEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDEmployee,
            this.EmployeeName,
            this.EmployeeSurname,
            this.DateStart,
            this.DateEnd,
            this.Salary});
            this.gridEmployees.GridControl = this.gridControl1;
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // IDEmployee
            // 
            this.IDEmployee.Caption = "ID";
            this.IDEmployee.FieldName = "ID";
            this.IDEmployee.MinWidth = 25;
            this.IDEmployee.Name = "IDEmployee";
            this.IDEmployee.Width = 94;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Name";
            this.EmployeeName.FieldName = "Name";
            this.EmployeeName.MinWidth = 25;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 0;
            this.EmployeeName.Width = 94;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Caption = "Surname";
            this.EmployeeSurname.FieldName = "Surname";
            this.EmployeeSurname.MinWidth = 25;
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Visible = true;
            this.EmployeeSurname.VisibleIndex = 1;
            this.EmployeeSurname.Width = 94;
            // 
            // DateStart
            // 
            this.DateStart.Caption = "Start Date";
            this.DateStart.ColumnEdit = this.repDateEdit;
            this.DateStart.FieldName = "DateStart";
            this.DateStart.MinWidth = 25;
            this.DateStart.Name = "DateStart";
            this.DateStart.Visible = true;
            this.DateStart.VisibleIndex = 2;
            this.DateStart.Width = 94;
            // 
            // DateEnd
            // 
            this.DateEnd.Caption = "End Date";
            this.DateEnd.ColumnEdit = this.repDateEdit;
            this.DateEnd.FieldName = "DateEnd";
            this.DateEnd.MinWidth = 25;
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Visible = true;
            this.DateEnd.VisibleIndex = 3;
            this.DateEnd.Width = 94;
            // 
            // Salary
            // 
            this.Salary.Caption = "Salary";
            this.Salary.FieldName = "Salary";
            this.Salary.MinWidth = 25;
            this.Salary.Name = "Salary";
            this.Salary.Visible = true;
            this.Salary.VisibleIndex = 4;
            this.Salary.Width = 94;
            // 
            // gridTransactionLine
            // 
            this.gridTransactionLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDTransactionLine,
            this.TransactionID,
            this.ItemiD,
            this.Quantity,
            this.ItemPrice,
            this.Value});
            this.gridTransactionLine.GridControl = this.gridControl1;
            this.gridTransactionLine.Name = "gridTransactionLine";
            this.gridTransactionLine.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // IDTransactionLine
            // 
            this.IDTransactionLine.Caption = "Transaction ID";
            this.IDTransactionLine.FieldName = "ID";
            this.IDTransactionLine.MinWidth = 25;
            this.IDTransactionLine.Name = "IDTransactionLine";
            this.IDTransactionLine.Width = 94;
            // 
            // TransactionID
            // 
            this.TransactionID.Caption = "ID";
            this.TransactionID.FieldName = "ID";
            this.TransactionID.MinWidth = 25;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.Width = 94;
            // 
            // ItemiD
            // 
            this.ItemiD.Caption = "Item ID";
            this.ItemiD.FieldName = "ID";
            this.ItemiD.MinWidth = 25;
            this.ItemiD.Name = "ItemiD";
            this.ItemiD.Width = 94;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 25;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 0;
            this.Quantity.Width = 94;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Caption = "Item Price";
            this.ItemPrice.FieldName = "Price";
            this.ItemPrice.MinWidth = 25;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Visible = true;
            this.ItemPrice.VisibleIndex = 1;
            this.ItemPrice.Width = 94;
            // 
            // Value
            // 
            this.Value.Caption = "Value";
            this.Value.FieldName = "Value";
            this.Value.MinWidth = 25;
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 2;
            this.Value.Width = 94;
            // 
            // MainForm
            // 
            this.ActiveGlowColor = System.Drawing.Color.Transparent;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 589);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar2);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar2;
            this.Text = "Fuel Station Management Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage transactions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ViewAndEditTransactions;
        private DevExpress.XtraBars.Ribbon.RibbonPage customers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup modifyCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPage employees;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup viewAndEditEmployees;
        private DevExpress.XtraBars.Ribbon.RibbonPage ledger;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup viewLedger;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.BarButtonItem addTransaction;
        private DevExpress.XtraBars.BarButtonItem getTransactions;
        private DevExpress.XtraBars.BarButtonItem deleteTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup modifyTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup deleteTransactionPageGroup;
        private FuelStationDBDataSet fuelStationDBDataSet;
        private System.Windows.Forms.BindingSource fuelStationDBDataSetBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTransactions;
        private DevExpress.XtraBars.BarButtonItem addCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridItems;
        private DevExpress.XtraGrid.Columns.GridColumn IDTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn TotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn IDItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup viewAndEditCustomers;
        private DevExpress.XtraBars.BarButtonItem getCustomers;
        private DevExpress.XtraBars.BarButtonItem deleteCustomer2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup deleteCustomerPageGroup;
        private DevExpress.XtraBars.BarButtonItem getEmployees;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup modifyEmployee;
        private DevExpress.XtraBars.BarButtonItem addEmployee;
        private DevExpress.XtraBars.BarButtonItem deleteEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup deleteEmployeePageGroup;
        private DevExpress.XtraBars.BarButtonItem showLedger;
        private DevExpress.XtraBars.Ribbon.RibbonPage items;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup viewAndEditItems;
        private DevExpress.XtraBars.BarButtonItem getAllItems;
        private DevExpress.XtraBars.BarButtonItem addItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup modifyItems;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup deleteItemPageGroup;
        private DevExpress.XtraBars.BarButtonItem deleteItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLedger;
        private DevExpress.XtraGrid.Columns.GridColumn IDLedger;
        private DevExpress.XtraGrid.Columns.GridColumn DateFrom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn IDCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn IDEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn ItemType;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraGrid.Columns.GridColumn Surname;
        private DevExpress.XtraGrid.Columns.GridColumn CardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeSurname;
        private DevExpress.XtraGrid.Columns.GridColumn DateStart;
        private DevExpress.XtraGrid.Columns.GridColumn DateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn Salary;
        private DevExpress.XtraGrid.Columns.GridColumn DateTo;
        private DevExpress.XtraGrid.Columns.GridColumn Income;
        private DevExpress.XtraGrid.Columns.GridColumn Expenses;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraBars.BarButtonItem openSelectedTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory transactionCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPage actions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup viewAndEditTransactionLinesPageGroup;
        private DevExpress.XtraBars.BarButtonItem getTransactionLines;
        private DevExpress.XtraBars.BarButtonItem saveTransactionChanges;
        private DevExpress.XtraBars.BarButtonItem saveItemChanges;
        private DevExpress.XtraBars.BarButtonItem saveCustomerChanges;
        private DevExpress.XtraBars.BarButtonItem saveEmployeeChanges;
        private DevExpress.XtraBars.BarButtonItem saveTransChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveTLPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup modifyTL;
        private DevExpress.XtraBars.BarButtonItem addTransactionLine;
        private DevExpress.XtraBars.BarButtonItem deleteTransLine;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup deleteTLPageGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTransactionLine;
        private DevExpress.XtraGrid.Columns.GridColumn IDTransactionLine;
        private DevExpress.XtraGrid.Columns.GridColumn TransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn ItemiD;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn ItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraBars.BarButtonItem getCustomerDetails;
        private DevExpress.XtraBars.BarButtonItem saveCustomersChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveCustomerPageGroup;
        private DevExpress.XtraBars.BarButtonItem saveTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveTransactionChangesPG;
        private DevExpress.XtraBars.BarButtonItem saveItemsChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveItemsChangesPG;
        private DevExpress.XtraBars.BarButtonItem saveEmployeesChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup saveEmployeePG;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repEnum;
    }
}

