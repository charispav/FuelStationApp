﻿using System;
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

        private SqlConnection _SqlConnection;
        private DataSet _MasterData = new DataSet();
        public MainForm() {
            InitializeComponent();
        }

       

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}