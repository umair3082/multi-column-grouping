public BindingSource bindingSource1 = new BindingSource();
        public  DataTable GetData(string sqlCommand,string connectionString)
        {
        
            SqlConnection con = new SqlConnection(connectionString);
        
            SqlCommand command = new SqlCommand(sqlCommand,con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
