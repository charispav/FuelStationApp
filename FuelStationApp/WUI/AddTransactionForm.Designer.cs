
namespace FuelStationApp.WUI {
    partial class AddTransactionForm {
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btQuantity = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblChooseItem = new DevExpress.XtraEditors.LabelControl();
            this.lblTransaction = new DevExpress.XtraEditors.LabelControl();
            this.lblQuantity = new DevExpress.XtraEditors.LabelControl();
            this.ctrlPBD = new DevExpress.XtraEditors.TextEdit();
            this.ctrlDiscount = new DevExpress.XtraEditors.TextEdit();
            this.ctrlTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblPBD = new DevExpress.XtraEditors.LabelControl();
            this.lblDiscount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCCN = new DevExpress.XtraEditors.TextEdit();
            this.lblCCN = new DevExpress.XtraEditors.LabelControl();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlQuantity = new DevExpress.XtraEditors.TextEdit();
            this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(26, 119);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(377, 335);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl2.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCost,
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colCost
            // 
            this.colCost.Caption = "Cost";
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colItemType
            // 
            this.colItemType.Caption = "ItemType";
            this.colItemType.FieldName = "ItemType";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(677, 119);
            this.gridControl3.MainView = this.gridView2;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDelete});
            this.gridControl3.Size = new System.Drawing.Size(505, 335);
            this.gridControl3.TabIndex = 1;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode2,
            this.colDescription2,
            this.colID2,
            this.colTransactionID2,
            this.colItemID2,
            this.colQuantity,
            this.colItemPrice,
            this.colValue,
            this.colItemType2,
            this.colDelete});
            this.gridView2.GridControl = this.gridControl3;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // colCode2
            // 
            this.colCode2.Caption = "Code";
            this.colCode2.Name = "colCode2";
            // 
            // colDescription2
            // 
            this.colDescription2.Caption = "Description";
            this.colDescription2.FieldName = "Description";
            this.colDescription2.Name = "colDescription2";
            this.colDescription2.Visible = true;
            this.colDescription2.VisibleIndex = 0;
            // 
            // colID2
            // 
            this.colID2.Caption = "ID";
            this.colID2.FieldName = "ID";
            this.colID2.Name = "colID2";
            // 
            // colTransactionID2
            // 
            this.colTransactionID2.Caption = "TransactionID";
            this.colTransactionID2.FieldName = "TransactionID";
            this.colTransactionID2.Name = "colTransactionID2";
            // 
            // colItemID2
            // 
            this.colItemID2.Caption = "ItemID";
            this.colItemID2.FieldName = "ItemID";
            this.colItemID2.Name = "colItemID2";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colItemPrice
            // 
            this.colItemPrice.Caption = "Item Price";
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 2;
            // 
            // colValue
            // 
            this.colValue.Caption = "Value";
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 3;
            // 
            // colItemType2
            // 
            this.colItemType2.Caption = "Item Type";
            this.colItemType2.FieldName = "ItemType";
            this.colItemType2.Name = "colItemType2";
            this.colItemType2.Visible = true;
            this.colItemType2.VisibleIndex = 4;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Delete";
            this.colDelete.ColumnEdit = this.repDelete;
            this.colDelete.Name = "colDelete";
            // 
            // repDelete
            // 
            this.repDelete.AutoHeight = false;
            this.repDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repDelete.Name = "repDelete";
            this.repDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btQuantity
            // 
            this.btQuantity.Appearance.BackColor = System.Drawing.Color.Purple;
            this.btQuantity.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btQuantity.Appearance.Options.UseBackColor = true;
            this.btQuantity.Appearance.Options.UseFont = true;
            this.btQuantity.Location = new System.Drawing.Point(507, 281);
            this.btQuantity.Name = "btQuantity";
            this.btQuantity.Size = new System.Drawing.Size(107, 41);
            this.btQuantity.TabIndex = 3;
            this.btQuantity.Text = "Add Item(s)";
            this.btQuantity.Click += new System.EventHandler(this.btQuantity_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(986, 587);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 34);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblChooseItem
            // 
            this.lblChooseItem.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblChooseItem.Appearance.Options.UseFont = true;
            this.lblChooseItem.Location = new System.Drawing.Point(26, 96);
            this.lblChooseItem.Name = "lblChooseItem";
            this.lblChooseItem.Size = new System.Drawing.Size(81, 19);
            this.lblChooseItem.TabIndex = 5;
            this.lblChooseItem.Text = "Choose Item:";
            // 
            // lblTransaction
            // 
            this.lblTransaction.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTransaction.Appearance.Options.UseFont = true;
            this.lblTransaction.Location = new System.Drawing.Point(677, 96);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(70, 19);
            this.lblTransaction.TabIndex = 6;
            this.lblTransaction.Text = "Transaction";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblQuantity.Appearance.Options.UseFont = true;
            this.lblQuantity.Location = new System.Drawing.Point(435, 235);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(57, 19);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity:";
            // 
            // ctrlPBD
            // 
            this.ctrlPBD.Location = new System.Drawing.Point(240, 501);
            this.ctrlPBD.Name = "ctrlPBD";
            this.ctrlPBD.Properties.ReadOnly = true;
            this.ctrlPBD.Size = new System.Drawing.Size(100, 20);
            this.ctrlPBD.TabIndex = 8;
            // 
            // ctrlDiscount
            // 
            this.ctrlDiscount.Location = new System.Drawing.Point(556, 501);
            this.ctrlDiscount.Name = "ctrlDiscount";
            this.ctrlDiscount.Properties.ReadOnly = true;
            this.ctrlDiscount.Size = new System.Drawing.Size(100, 20);
            this.ctrlDiscount.TabIndex = 9;
            // 
            // ctrlTotalPrice
            // 
            this.ctrlTotalPrice.Location = new System.Drawing.Point(849, 501);
            this.ctrlTotalPrice.Name = "ctrlTotalPrice";
            this.ctrlTotalPrice.Properties.ReadOnly = true;
            this.ctrlTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.ctrlTotalPrice.TabIndex = 10;
            // 
            // lblPBD
            // 
            this.lblPBD.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPBD.Appearance.Options.UseFont = true;
            this.lblPBD.Location = new System.Drawing.Point(57, 502);
            this.lblPBD.Name = "lblPBD";
            this.lblPBD.Size = new System.Drawing.Size(133, 19);
            this.lblPBD.TabIndex = 11;
            this.lblPBD.Text = "Price Before Discount:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDiscount.Appearance.Options.UseFont = true;
            this.lblDiscount.Location = new System.Drawing.Point(404, 502);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(76, 19);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "Discount(%):";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalPrice.Appearance.Options.UseFont = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(721, 500);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(66, 19);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Total Price:";
            this.lblTotalPrice.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // ctrlCCN
            // 
            this.ctrlCCN.Location = new System.Drawing.Point(201, 40);
            this.ctrlCCN.Name = "ctrlCCN";
            this.ctrlCCN.Size = new System.Drawing.Size(100, 20);
            this.ctrlCCN.TabIndex = 14;
            this.ctrlCCN.EditValueChanged += new System.EventHandler(this.ctrlCCN_EditValueChanged);
            // 
            // lblCCN
            // 
            this.lblCCN.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCCN.Appearance.Options.UseFont = true;
            this.lblCCN.Location = new System.Drawing.Point(26, 39);
            this.lblCCN.Name = "lblCCN";
            this.lblCCN.Size = new System.Drawing.Size(150, 19);
            this.lblCCN.TabIndex = 15;
            this.lblCCN.Text = "Customer Card Number:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.BackColor = System.Drawing.Color.Purple;
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnConfirm.Appearance.Options.UseBackColor = true;
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.Location = new System.Drawing.Point(319, 29);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 35);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Location = new System.Drawing.Point(507, 236);
            this.ctrlQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(107, 20);
            this.ctrlQuantity.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculate.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCalculate.Appearance.Options.UseBackColor = true;
            this.btnCalculate.Appearance.Options.UseFont = true;
            this.btnCalculate.Location = new System.Drawing.Point(1011, 486);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 46);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate Total Price";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(1115, 587);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 34);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(507, 282);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 41);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Add Item(s)";
            this.simpleButton1.Click += new System.EventHandler(this.btQuantity_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(319, 30);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(84, 35);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Confirm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AddTransactionForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 632);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblCCN);
            this.Controls.Add(this.ctrlCCN);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPBD);
            this.Controls.Add(this.ctrlTotalPrice);
            this.Controls.Add(this.ctrlDiscount);
            this.Controls.Add(this.ctrlPBD);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.lblChooseItem);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btQuantity);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.gridControl2);
            this.Name = "AddTransactionForm";
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btQuantity;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl lblChooseItem;
        private DevExpress.XtraEditors.LabelControl lblTransaction;
        private DevExpress.XtraEditors.LabelControl lblQuantity;
        private DevExpress.XtraEditors.TextEdit ctrlPBD;
        private DevExpress.XtraEditors.TextEdit ctrlDiscount;
        private DevExpress.XtraEditors.TextEdit ctrlTotalPrice;
        private DevExpress.XtraEditors.LabelControl lblPBD;
        private DevExpress.XtraEditors.LabelControl lblDiscount;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.TextEdit ctrlCCN;
        private DevExpress.XtraEditors.LabelControl lblCCN;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCode2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription2;
        private DevExpress.XtraGrid.Columns.GridColumn colID2;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID2;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDelete;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType2;
        private DevExpress.XtraEditors.TextEdit ctrlQuantity;
        private DevExpress.XtraEditors.SimpleButton btnCalculate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}