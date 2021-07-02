using DevExpress.XtraEditors;
using FuelStationApp.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationApp.WUI {
    public partial class AddForm : DevExpress.XtraEditors.XtraForm {

        public DataSet _MasterData { get; set; }
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
                    break;
                case EntityTypeEnum.Employee:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), textEdit1.EditValue, textEdit2.EditValue, dateEdit3.EditValue, dateEdit4.EditValue, textEdit5.EditValue);
                    break;
                case EntityTypeEnum.Item:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), textEdit1.EditValue, textEdit2.EditValue, comboBoxEdit1.EditValue, textEdit4.EditValue.ToString().Replace(',','.'), textEdit5.EditValue.ToString().Replace(',', '.'));
                    break;
                case EntityTypeEnum.Ledger:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), dateEdit1.EditValue, dateEdit2.EditValue);
                    break;
                default:
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
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