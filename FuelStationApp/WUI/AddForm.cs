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
                case EntityTypeEnum.Transaction:
                    break;
                case EntityTypeEnum.TransactionLine:
                    break;
                case EntityTypeEnum.Customer:

                    lblTitle.Text = "Add New Customer...";
                    label1.Text = "Name:";
                    label2.Text = "Surname:";
                    label3.Text = "Card Number:";
                    label4.Visible= false;
                    textEdit4.Visible = false;
                    label5.Visible = false;
                    textEdit5.Visible = false;
                    comboBoxEdit1.Visible = false;
                    break;
                case EntityTypeEnum.Employee:
                    lblTitle.Text = "Add New Employee...";
                    label1.Text = "Name:";
                    label2.Text = "Date Start:";
                    label3.Text = "Date End:";
                    label4.Text = "Salary:";
                    label5.Visible = false;
                    textEdit5.Visible = false;
                    comboBoxEdit1.Visible = false;
                    break;
                case EntityTypeEnum.Item:
                    lblTitle.Text = "Add New Item...";
                    label1.Text = "Code:";
                    label2.Text = "Description:";
                    label3.Text = "ItemType:";
                    ComboBoxLoad();
                    comboBoxEdit1.Visible = true;
                    label4.Text = "Price:";
                    label5.Text = "Cost:";
                   
                    break;
                case EntityTypeEnum.Ledger:
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
                    break;
                default:
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            switch (_entity) {
                case EntityTypeEnum.Transaction:
                    break;
                case EntityTypeEnum.TransactionLine:
                    break;
                case EntityTypeEnum.Customer:
                   
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(),textEdit1.EditValue, textEdit2.EditValue, textEdit3.EditValue);

                    break;
                case EntityTypeEnum.Employee:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), textEdit1.EditValue, textEdit2.EditValue, textEdit3.EditValue, textEdit4.EditValue);
                    break;
                case EntityTypeEnum.Item:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), textEdit1.EditValue, textEdit2.EditValue, textEdit3.EditValue, textEdit4.EditValue, textEdit5.EditValue);
                    break;
                case EntityTypeEnum.Ledger:
                    _MasterData.Tables[0].Rows.Add(Guid.NewGuid(), textEdit1.EditValue, textEdit2.EditValue);
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
            List<ItemTypeEnum> enumList = Enum.GetValues(typeof(ItemTypeEnum)).Cast<ItemTypeEnum>().ToList();

            foreach (ItemTypeEnum item in enumList) {
               // comboBoxEdit1.Items.Add(item.ToString());
            }
        }
        private void textEdit4_EditValueChanged(object sender, EventArgs e) {

        }
    }
}