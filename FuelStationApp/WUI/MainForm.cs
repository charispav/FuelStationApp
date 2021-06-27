
using DevExpress.XtraGrid.Views.Grid;
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

        //private GridView gridView = new GridView();
        public MainForm(SqlConnection sqlConnection) {
            _SqlConnection = sqlConnection;
            InitializeComponent();
        }

       
        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void ribbonControl1_Click(object sender, EventArgs e) {

        }

        private void GetData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [Name],[Surname] FROM CUSTOMERS", _SqlConnection);
                adapter.Fill(MasterData);

            }
            catch (Exception ex) {
               
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetData();
            gridControl1.DataSource = MasterData.Tables[0];
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //gridControl2.MainView.CloseEditor();
            
           //gridView2.vis
        }
    }
}
