using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AutoDownLoadFile
{
    internal class DataBaseHelper
    {
        //public static string connstr = "server=.;database=SuperKTV;uid=sa;pwd=123456";

        public static string connstr = "";
        //数据库链接对象
        private static SqlConnection Conn = null;

        //初始化数据库链接
        private static void InitConnection()
        {
            //如果连接对象不存在，创建连接
            if (Conn == null)
                Conn = new SqlConnection(connstr);
            //如果连接对象关闭，打开连接
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            //如果连接中断，重启连接
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }

        //查询，获取DataReader
        public static SqlDataReader GetDataReader(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            //CommandBehavior.CloseConnection 命令行为：当DataReader对象被关闭时，自动关闭占用的连接对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        //查询，获取DataTable
        public static DataTable GetDataTable(string sqlStr, string storeName)
        {
            connstr = "";
            connstr = ";database=TPCentralDB;uid=SQLTPCentral;pwd=Y59-B,Tdi*u5";
            Conn = null;
            //InitConnection();
            connstr = "server=" + storeName + DataBaseHelper.connstr;
            //如果连接对象不存在，创建连接
            if (Conn == null)
                Conn = new SqlConnection(connstr);
            //如果连接对象关闭，打开连接
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            //如果连接中断，重启连接
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr, Conn);
            dap.Fill(table);
            Conn.Close();
            return table;
        }

        //查询，获取DataSet
        public static DataSet GetDataSet(string sqlStr)
        {
            InitConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr, Conn);
            dap.Fill(ds);
            Conn.Close();
            return ds;
        }

        //增改删
        public static bool ExecuteNonQuery(string sqlStr, string storeName)
        {
            connstr = "";
            connstr = ";database=TPCentralDB;uid=SQLTPCentral;pwd=Y59-B,Tdi*u5";
            Conn = null;
            //InitConnection();
            connstr = "server=" + storeName + DataBaseHelper.connstr;
            //如果连接对象不存在，创建连接
            if (Conn == null)
                Conn = new SqlConnection(connstr);
            //如果连接对象关闭，打开连接
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            //如果连接中断，重启连接
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            return result > 0;
        }

        //执行集合函数
        public static object ExecuteScalar(string sqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            object result = cmd.ExecuteScalar();
            Conn.Close();
            return result;
        }
    }
}
