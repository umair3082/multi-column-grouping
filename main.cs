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
            com.bindingSource1.DataSource = com.GetData("select AccNo,AccType,SubAccType, SubAccType1 , AccName from tblAccounts");
            comboTree1.DataSource = com.bindingSource1;
            comboTree1.GroupingMembers = "AccType,SubAccType,SubAccType1,AccName";
            comboTree1.ValueMember = "AccNo";
            comboTree1.DisplayMembers = "AccNo,AccName";
            comboTree1.SelectedDisplayMember = "AccName";
        }
         private void comboTree1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = comboTree1.SelectedValue.ToString();
        }
    }
}
