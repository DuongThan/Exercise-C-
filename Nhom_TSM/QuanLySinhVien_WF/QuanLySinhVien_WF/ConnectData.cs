﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_WF
{
    class ConnectData
    {
        private SqlConnection connect;
        public void Connect()
        {
            connect = new SqlConnection(@"Data Source=.\DUONGTHAN;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            connect.Open();
        }

        public void DisConnect()
        {
            connect.Close();
        }

        public DataTable GetTable(string strsql)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(strsql, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DisConnect();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public void ExecuteSql(string strsql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(strsql, connect);
            cmd.ExecuteNonQuery();
            DisConnect();

        }
    }
}
