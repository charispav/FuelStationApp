using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using FuelStationApp.Properties;
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
    public partial class WizardForm : DevExpress.XtraEditors.XtraForm {

        public DialogResult DialogResultSpecific { get; set; } = DialogResult.Cancel;
        private SqlConnection SqlConnection { get; set; }
        private DataSet _AccountData = new DataSet();
        private string invalidConnectionString = "Invalid connection string!";
        private string invaldLoginInformation = "The login information you supplied is not valid.";

        public WizardForm() {
            InitializeComponent();
        }

        #region Form Events
        private void wizardControl1_CancelClick(object sender, CancelEventArgs e) {
            Application.Exit();
        }


        private void welcomeWizardPage1_PageValidating(object sender, WizardPageValidatingEventArgs e) {
            e.Valid = SqlConnect();
            if (!e.Valid)
                e.ErrorText = invalidConnectionString;
        }

        private void wizardPage1_PageValidating(object sender, WizardPageValidatingEventArgs e) {
            e.Valid = IsValidLogin(Convert.ToString(ctrlUsername.EditValue),Convert.ToString(ctrlPassword.EditValue));
            
            if (!e.Valid)
                e.ErrorText = invaldLoginInformation;
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e) {
            DialogResultSpecific = DialogResult.OK;
            Close();
        }
        #endregion

        #region Methods
        private bool IsValidLogin(string username,string password) {

            bool condition = false;
            SqlDataAdapter adapter = new SqlDataAdapter(Resources.AccountCredentialsSelect, SqlConnection);
            adapter.Fill(_AccountData);

            for (int i = 0; i < _AccountData.Tables[0].Rows.Count; i++) {

                if (Equals(Convert.ToString(_AccountData.Tables[0].Rows[i].ItemArray[0]), username)
                    && Equals(Convert.ToString(_AccountData.Tables[0].Rows[i].ItemArray[1]).Trim(), password)) {
                    condition = true;
                    break;
                }
            }
            
            return condition;
        }

        public bool SqlConnect() {

            //SqlConnection = new SqlConnection(Convert.ToString(ctrlConnectionString.EditValue));
             //SqlConnection = new SqlConnection("data source=LAPTOP-VB1FTM5C;initial catalog=FuelStation;trusted_connection=true;");
             SqlConnection = new SqlConnection(@"Data Source=.;Initial Catalog=FuelStationDB;Integrated Security=True;");///////////
            //SqlConnection = new SqlConnection(@"Data Source=.;Initial Catalog=FuelStation;Integrated Security=True;");
            try {
                SqlConnection.Open();
            }
            catch (Exception) {
               
            }
            return SqlConnection.State == ConnectionState.Open;
        }

        public MainForm StartApplication() {
            MainForm mainForm = new MainForm(SqlConnection); 
            
        return mainForm;
            
        }

        #endregion

        private void WizardForm_Load(object sender, EventArgs e) {

        }

        private void welcomeWizardPage1_Click(object sender, EventArgs e) {

        }

        private void ctrlConnectionString_EditValueChanged(object sender, EventArgs e) {

        }
    }
}
