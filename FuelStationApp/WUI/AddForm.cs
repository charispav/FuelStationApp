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

        public object _addObject { get; set; }
        public AddForm(object addObject) {
            _addObject = addObject;
            InitializeComponent();

        }
        
        private void AddForm_Load(object sender, EventArgs e) {
            switch (_addObject) {
                case Customer _addObject: {
                        //MessageBox.Show("OK");
                        break;
                    }
                case Employee _addObject: {
                        // MessageBox.Show("NOT OK");
                        break;
                    }
                //TODO: REST CASES
                default:
                    break;
            }
        }
    }
}