using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace TailoringMSystem
{
    public partial class frm_jv : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frm_jv()
        {
            InitializeComponent();
        }
        Common_Code com = new Common_Code();
         private void frm_jv_Load(object sender, EventArgs e)
        {           
           com.bindingSource1.DataSource = com.GetData("select AccNo,AccType,SubAccType, SubAccType1 , AccName from tblAccounts",Properties.Resources.constring);
            //here you will enter you own connection string

            comboTree1.DataSource = com.bindingSource1;
            //pass data source to data source
            comboTree1.GroupingMembers = "AccType,SubAccType,SubAccType1,AccName";
            // it will group data as above column feilds 
            comboTree1.ValueMember = "AccNo";
            //what ever we select data it will give us AccNo Value
            comboTree1.DisplayMembers = "AccNo,AccName";
            //you can see 5 columns AccType,SubAccType,SubAccType1,AccName
            //but it will display only AccNo,AccName in drop down
            comboTree1.SelectedDisplayMember = "AccName";
            //this value will be displayed on selected value
        }
         private void comboTree1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = comboTree1.SelectedValue.ToString();
        }
    }
}
