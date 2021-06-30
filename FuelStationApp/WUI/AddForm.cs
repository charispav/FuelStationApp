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


                    break;
                case EntityTypeEnum.Employee:
                    break;
                case EntityTypeEnum.Item:
                    break;
                case EntityTypeEnum.Ledger:
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
                    break;
                case EntityTypeEnum.Item:
                    break;
                case EntityTypeEnum.Ledger:
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
    }
}