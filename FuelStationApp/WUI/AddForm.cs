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
    public partial class AddForm : DevExpress.XtraEditors.XtraForm {

        public DataSet _MasterData { get; set; }
        public SqlConnection SqlConnectionAddForm { get; set; }
        public EntityTypeEnum _entity { get; set; }
        public AddForm(EntityTypeEnum entity) {
            _entity = entity;
            InitializeComponent();

        }
        
        private void AddForm_Load(object sender, EventArgs e) {
            switch (_entity) {
                
                case EntityTypeEnum.Customer:
                    this.Text = "Add Customer";
                    lblTitle.Text = "Add New Customer...";
                    label1.Text = "Name:";
                    label2.Text = "Surname:";
                    label3.Text = "Card Number:";
                    label4.Visible= false;
                    textEdit4.Visible = false;
                    label5.Visible = false;
                    textEdit5.Visible = false;
                    comboBoxEdit1.Visible = false;
                    dateEdit1.Visible = false;
                    dateEdit2.Visible = false;
                    dateEdit3.Visible = false;
                    dateEdit4.Visible = false;
                    break;
                case EntityTypeEnum.Employee:
                    this.Text = "Add Employee";
                    lblTitle.Text = "Add New Employee...";
                    label1.Text = "Name:";
                    label2.Text = "Surname";
                    label3.Text = "Date Start:";
                    label4.Text = "Date End:";
                    label5.Text = "Salary:";
                    comboBoxEdit1.Visible = false;
                    dateEdit1.Visible = false;
                    dateEdit2.Visible = false;
                    break;
                case EntityTypeEnum.Item:
                    this.Text = "Add Item";
                    lblTitle.Text = "Add New Item...";
                    label1.Text = "Code:";
                    label2.Text = "Description:";
                    label3.Text = "Item Type:";
                    textEdit3.Visible = false;
                    ComboBoxLoad();
                    comboBoxEdit1.Visible = true;
                    label4.Text = "Price:";
                    label5.Text = "Cost:";
                    dateEdit1.Visible = false;
                    dateEdit2.Visible = false;
                    dateEdit3.Visible = false;
                    dateEdit4.Visible = false;
                    break;
                case EntityTypeEnum.Ledger:
                    this.Text = "Add Ledger";
                    lblTitle.Text = "Add New Ledger...";
                    label1.Text = "Date From:";
                    label2.Text = "Date To:";
                    label3.Visible = false;
                    textEdit3.Visible = false;
                    label4.Visible = false;
                    textEdit4.Visible = false;
                    label5.Visible = false;
                    textEdit5.Visible = false;
                    comboBoxEdit1.Visible = false;
                    dateEdit3.Visible = false;
                    dateEdit4.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            switch (_entity) {
                case EntityTypeEnum.Customer:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(),textEdit1.EditValue, textEdit2.EditValue, textEdit3.EditValue);
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                case EntityTypeEnum.Employee:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), textEdit1.EditValue, textEdit2.EditValue, dateEdit3.EditValue, dateEdit4.EditValue, textEdit5.EditValue);
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                case EntityTypeEnum.Item:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), textEdit1.EditValue, textEdit2.EditValue, comboBoxEdit1.EditValue.ToString(), textEdit4.EditValue, textEdit5.EditValue);
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                case EntityTypeEnum.Ledger:
                    decimal rent = 5000m;
                    decimal rentPerDay = 0m;
                   rentPerDay = rent / 30;
                    
                    string startDate = Convert.ToDateTime(dateEdit1.EditValue).ToString("yyyyMMdd");
                    string endDate = Convert.ToDateTime(dateEdit2.EditValue).ToString("yyyyMMdd");
                    
                    if (Convert.ToDateTime(dateEdit1.EditValue) < Convert.ToDateTime(dateEdit2.EditValue)) {
                        
                        
                        int days = (Convert.ToDateTime(dateEdit2.EditValue) - Convert.ToDateTime(dateEdit1.EditValue)).Days;
                        //Expenses:
                        decimal expenses=0m;
                        decimal totalRent = 0m;
                        totalRent = days * rentPerDay;

                        SqlDataAdapter adapter = new SqlDataAdapter($"SELECT SUM( CASE WHEN dateStart <= '{startDate}' AND dateEnd >= '{endDate}' THEN(1 + DATEDIFF(day, '{startDate}', '{endDate}')) * (salary / 25) WHEN dateStart >= '{startDate}' AND dateEnd >= '{endDate}' THEN(1 + DATEDIFF(day, dateStart, '{endDate}')) * (salary / 25) WHEN dateStart <= '{startDate}' AND dateEnd <= '{endDate}' THEN(1 + DATEDIFF(day, '{startDate}', dateEnd)) * (salary / 25) WHEN dateStart >= '{startDate}' AND dateEnd <= '{endDate}' THEN(1 + DATEDIFF(day, dateStart, dateEnd)) * (salary / 25) END) FROM Employee WHERE(DateStart <= '{endDate}' and DateEnd >= '{startDate}')", SqlConnectionAddForm);
                        DataTable employeeExpenses = new DataTable();
                        adapter.Fill(employeeExpenses);

                        SqlDataAdapter adapterTransactionExpenses = new SqlDataAdapter($"SELECT Sum(Cost *Quantity) AS TotalCost FROM Items RIGHT JOIN (SELECT TransactionId, ItemID, Quantity  FROM[TransactionLine] LEFT JOIN[Transaction] ON[TransactionLine].TransactionId =[Transaction].ID WHERE Date BETWEEN '{startDate}' AND '{endDate}') A ON A.ItemID = Items.ID", SqlConnectionAddForm);
                        DataTable transactionExpenses = new DataTable();
                        adapterTransactionExpenses.Fill(transactionExpenses);
                        expenses= totalRent + Convert.ToDecimal(employeeExpenses.Rows[0].ItemArray[0])+ Convert.ToDecimal(transactionExpenses.Rows[0].ItemArray[0]);

                        //Income:
                        decimal income = 0m;

                        SqlDataAdapter adapterIncome = new SqlDataAdapter($"SELECT SUM(DiscountValue) FROM [Transaction] WHERE Date BETWEEN '{startDate}' AND '{endDate}'", SqlConnectionAddForm);
                        DataTable transactionIncome = new DataTable();
                        adapterIncome.Fill(transactionIncome);
                        income = Convert.ToDecimal(transactionIncome.Rows[0].ItemArray[0]);
                        //Total:
                        decimal total = income - expenses;
                        DataRow row = _MasterData.Tables["Ledger"].NewRow();
                       
                        _MasterData.Tables["Ledger"].Rows.Add(row);
                        row["DateFrom"] = Convert.ToDateTime(dateEdit1.EditValue).ToString("yyyyMMdd");
                        row["DateTo"] = Convert.ToDateTime(dateEdit2.EditValue).ToString("yyyyMMdd");
                        row["Income"] = income.ToString("0.00");
                        row["Expenses"] = expenses.ToString("0.00");
                        row["Total"] = total.ToString("0.00");

                       
                        DialogResult = DialogResult.OK;
                        Close();
                        
                    }
                    else { 
                        MessageBox.Show("Start Date is greater than end date!");
                    }

                    break;
                default:
                    break;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void ComboBoxLoad() {
            
            comboBoxEdit1.Properties.Items.AddRange(typeof(ItemTypeEnum).GetEnumValues());
        }
       
    }
}