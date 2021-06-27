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
        public MainForm(SqlConnection sqlConnection) {
            _SqlConnection = sqlConnection;
            InitializeComponent();
        }

       
        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}
