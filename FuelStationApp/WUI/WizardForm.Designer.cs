
namespace FuelStationApp.WUI {
    partial class WizardForm {
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.ctrlConnectionString = new DevExpress.XtraEditors.TextEdit();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.ctrlPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlUsername = new DevExpress.XtraEditors.TextEdit();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlConnectionString.Properties)).BeginInit();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.FinishText = "&Start";
            this.wizardControl1.ImageWidth = 216;
            this.wizardControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wizardControl1.MinimumSize = new System.Drawing.Size(117, 131);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(790, 565);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.ctrlConnectionString);
            this.welcomeWizardPage1.IntroductionText = "First, a connection string must be given:";
            this.welcomeWizardPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(534, 401);
            this.welcomeWizardPage1.Text = "Connect to Database";
            this.welcomeWizardPage1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.welcomeWizardPage1_PageValidating);
            // 
            // ctrlConnectionString
            // 
            this.ctrlConnectionString.Location = new System.Drawing.Point(0, 29);
            this.ctrlConnectionString.Name = "ctrlConnectionString";
            this.ctrlConnectionString.Size = new System.Drawing.Size(531, 24);
            this.ctrlConnectionString.TabIndex = 0;
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.ctrlPassword);
            this.wizardPage1.Controls.Add(this.labelControl3);
            this.wizardPage1.Controls.Add(this.labelControl1);
            this.wizardPage1.Controls.Add(this.ctrlUsername);
            this.wizardPage1.DescriptionText = "Please fill in your credentials:";
            this.wizardPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(750, 387);
            this.wizardPage1.Text = "User Login";
            this.wizardPage1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage1_PageValidating);
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPassword.Location = new System.Drawing.Point(208, 177);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlPassword.Properties.Appearance.Options.UseFont = true;
            this.ctrlPassword.Properties.PasswordChar = '*';
            this.ctrlPassword.Properties.UseSystemPasswordChar = true;
            this.ctrlPassword.Size = new System.Drawing.Size(317, 32);
            this.ctrlPassword.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(208, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 20);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Password :";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(208, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 20);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Username :";
            // 
            // ctrlUsername
            // 
            this.ctrlUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlUsername.Location = new System.Drawing.Point(208, 107);
            this.ctrlUsername.Name = "ctrlUsername";
            this.ctrlUsername.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlUsername.Properties.Appearance.Options.UseFont = true;
            this.ctrlUsername.Size = new System.Drawing.Size(317, 32);
            this.ctrlUsername.TabIndex = 28;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.FinishText = "You are all set! ";
            this.completionWizardPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.ProceedText = "To begin, click Start";
            this.completionWizardPage1.Size = new System.Drawing.Size(534, 401);
            this.completionWizardPage1.Text = "All steps completed";
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 565);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initialization";
            this.Load += new System.EventHandler(this.WizardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlConnectionString.Properties)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUsername.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.TextEdit ctrlConnectionString;
        private DevExpress.XtraEditors.TextEdit ctrlPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlUsername;
    }
}