using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class MSql
    {
        public static string myConnectionString;
        public void Sql_Set(string IP)
        {
            myConnectionString = "server=" + IP + ",3306;uid=root;" +
        "pwd=zxcv5716;database=book;";
        }
        
        public void Build_0_Tsql_CreateAccount()
        {
            string SQL_Code = @"drop table if exists tabAccount;
                              create table tabAccount(
                              acc    nvarchar(128)       not null    primary key,
                              pw      nvarchar(128)       not null,
                              email   nvarchar(128)       not null
                              )";
            Submit_Tsql_NonQuery(SQL_Code);
        }
        
        public void Build_1_Tsql_CreateTables()
        {
            string Tsql_Code = @"drop table if exists tabBook;
        create table tabBook(
            編號          int             not null     AUTO_INCREMENT,
            名稱          char(128)   not null,    
            作者          char(128)   not null,
            出版社        char(128)   ,
            出版日期      date            ,
            價格      int             not null,
            ISBN          char(128)   ,
            分類          char(16)    not null,
            PRIMARY KEY(編號)
        );";
            Submit_Tsql_NonQuery(Tsql_Code);
        }

        public void Build_2_Tsql_CreateClassTable()
        {
            string Tsql_Code = @"drop table if exists tabClass;
        create table tabClass(
            id         int             not null     AUTO_INCREMENT,
            名稱          char(32)   not null,    
            PRIMARY KEY(id)
        );";
            Submit_Tsql_NonQuery(Tsql_Code);
        }

        public void Build_3_Tsql_CreateMember()
        {
            string SQL_Code = @"drop table if exists tabmember;
            create table tabmember(
            帳號     char(128)       not null    primary key,
            電子郵件 char(128)		not null,
            名稱     char(64)       ,
            性別     char(4)       not null,
            聯絡電話 char(16)		not null,
            加入時間 date			not null,
            管理員   bool
            );";
            Submit_Tsql_NonQuery(SQL_Code);
        }

        public void Build_4_Tsql_CreateLeaseBook()
        {
            string SQL_Code = @"drop table if exists tableasebook;
                                CREATE TABLE tableasebook(
                                名稱          char(128)       not null    primary key,
                                租借帳號         char(128)       not null,
                                租借時間        date        not null,
                                還期日             date
                                )";
            Submit_Tsql_NonQuery(SQL_Code);
        }

        public string Select_0_Tsql_Login(string Enter_Account="",string Enter_Password="")
        {
            Enter_Account = " " + Enter_Account;//??
            string SQL_Code = "select * from tabAccount where acc = '" + Enter_Account + "'";
            
            try
            {
                using (var connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(SQL_Code, connection))
                    {
                        MySqlDataReader dataReader = command.ExecuteReader();
                        string reader_name, reader_password;
                        bool _key = false;
                        while (dataReader.Read())
                        {
                            reader_name = Convert.ToString(dataReader["acc"]);
                            if (reader_name == Enter_Account)
                            {
                                _key = true;
                                reader_password = Convert.ToString(dataReader["pw"]);
                                if (reader_password == Enter_Password)
                                {
                                    MessageBox.Show("登入成功");
                                    BookMain BM = new BookMain();
                                    BM.SetUserAccount(Enter_Account.Replace(" ",""));
                                    BM.Show();
                                    
                                    return "login in";
                                }
                                else
                                {
                                    MessageBox.Show("密碼錯誤");
                                    break;
                                }
                            }
                        }
                        if (!_key) MessageBox.Show("帳號錯誤");
                    }
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            return null;
        }
        
        public string Select_1_Tsql_SearchID(int _ID)
        {
            string SQL_Code = "select * from tabBook where 編號 = " + _ID.ToString();
            string SQL_OutData = "";
            try
            {
                using (var connection  = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(SQL_Code, connection))
                    {
                        MySqlDataReader dataReader = command.ExecuteReader();
                        bool key = false;
                        while (dataReader.Read())
                        {
                            key = true;
                            SQL_OutData += Convert.ToString(dataReader["名稱"]) + "|";
                            SQL_OutData += Convert.ToString(dataReader["作者"]) + "|";
                            SQL_OutData += Convert.ToString(dataReader["出版社"]) + "|";
                            SQL_OutData += Convert.ToString(dataReader["出版日期"]) + "|";
                            SQL_OutData += Convert.ToString(dataReader["價格"]) + "|";
                            SQL_OutData += Convert.ToString(dataReader["ISBN"]) + "|";
                            SQL_OutData += Convert.ToString(dataReader["分類"]);
                        }
                        if (!key) { MessageBox.Show("未找到所輸入的編號");
                            return "null";
                        }
                        return SQL_OutData;
                    }
                }
            }
            catch (MySqlException _error)
            {
                MessageBox.Show(_error.ToString());
            }
            return null;
        }

        public string Select_2_Tsql_ListClass()
        {
            string SQL_Code = "SELECT * FROM tabClass";
            string SQL_OutData = "";
            using (var connection= new MySqlConnection(myConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(SQL_Code, connection))
                {
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        SQL_OutData += Convert.ToString(dataReader["名稱"]) + "|";
                    }
                }
            }
                return SQL_OutData.Substring(0,SQL_OutData.Length-1);
        }

        public bool Select_3_Tsql_EnterAccount(string email,string account)
        {
            string SQL_Code = "SELECT * FROM tabaccount WHERE acc = ' " + account + "' OR email = '" + email + "'";
            account = " " + account;
            try
            {
                using (var connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(SQL_Code, connection))
                    {
                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            if(email == Convert.ToString(dataReader["email"]))
                            {
                                MessageBox.Show("E-Mail重複\n請使用別組");
                                return false;
                            }
                            string test = Convert.ToString(dataReader["acc"]);
                            if (account == test)
                            {
                                MessageBox.Show("帳號重複\n請使用別組");
                                return false;
                            }
                        }
                    }
                }
            }
            catch(MySqlException error)
            {
                
                MessageBox.Show(error.ToString());
                return false;
            }
                return true;
        }
        
        public string Select_4_Tsql_AccountToMember(string user_acc)
        {
            string SQL_Code = "SELECT * FROM tabmember where 帳號 = '" + user_acc + "'";
            string SQL_OutData = "";
            using (var connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(SQL_Code, connection))
                {
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for(int i = 0; i < dataReader.FieldCount; i++)
                        {
                            SQL_OutData += Convert.ToString( dataReader[i]) +"|";
                        }
                        return SQL_OutData.Substring(0, SQL_OutData.Length - 1);
                    }
                }
            }
            return "";
        }

        public string Select_5_Tsql_SearchMember(string MemberAcc)
        {
            string SQL_Code = "SELECT * FROM tabmember WHERE 帳號 = '" + MemberAcc + "'";
            string SQL_Outdata = "";
            try
            {
                using (var connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(SQL_Code, connection))
                    {
                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            if (MemberAcc == Convert.ToString(dataReader["帳號"]))
                            {
                                SQL_Outdata += Convert.ToString(dataReader["帳號"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["電子郵件"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["名稱"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["性別"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["聯絡電話"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["加入時間"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["管理員"]);
                                return SQL_Outdata;
                            }
                        }
                    }
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.ToString());
            }
                return "";
        }
        public string Select_6_Tsql_SearchBook(string BookName)
        {
            string SQL_Code = "SELECT * FROM tabbook WHERE 名稱 = '" + BookName + "'";
            string SQL_Outdata = "";
            try
            {
                using (var connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(SQL_Code, connection))
                    {
                        MySqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            if (BookName == Convert.ToString(dataReader["名稱"]))
                            {
                                SQL_Outdata += Convert.ToString(dataReader["名稱"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["作者"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["出版社"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["出版日期"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["價格"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["ISBN"]) + "|";
                                SQL_Outdata += Convert.ToString(dataReader["分類"]);
                                return SQL_Outdata;
                            }
                        }
                    }
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            return "";
        }

        public void Insert_0_Tsql_InsertAccount(string r_email, string r_account, string r_password)
        {
            string SQL_Code = "INSERT INTO tabAccount values(' " + r_account + @"','" + r_password + @"','" + r_email + @"')";
            Submit_Tsql_NonQuery(SQL_Code);
        }

        public void Insert_1_Tsql_InsertTables(string _name, string _writer, string _publisher, DateTime _PublicationDate, int _Price, string _ISBN, int _Class)
        {
            string _date = _PublicationDate.Year + "/" + _PublicationDate.Month + "/" + _PublicationDate.Day;
            string SQL_Code = @"INSERT INTO tabBook (名稱,作者,出版社,出版日期,價格,ISBN,分類) VALUES('" + _name + "','" + _writer + "','" + _publisher + "','" + _date + "','" + _Price.ToString() + "','" + _ISBN + "','" + _Class.ToString() + "');";
            Submit_Tsql_NonQuery(SQL_Code);
            /*
             名稱"])
             作者"])
             出版社"
             出版日期
             價格
             ISBN"])
             分類"])
            */
        }

        public void Insert_2_Tsql_InsertClass(string[] SQL_data)
        {
            string SQL_Code = "INSERT INTO tabClass (名稱) VALUES('";
            for(int i =0;i < SQL_data.Length; i++)
            {
                SQL_Code += SQL_data[i] + "')";
                if (i != SQL_data.Length - 1) SQL_Code += ",('";
            }
            Submit_Tsql_NonQuery(SQL_Code);
        }

        public void Insert_3_Tsql_InsertMember(string r_account,string r_email,string r_name,string r_gender, string r_phone,bool r_admin)
        {
            string r_date = DateTime.Now.Year.ToString();
            if (DateTime.Now.Month < 10) r_date += "0";
            r_date += DateTime.Now.Month;
            if (DateTime.Now.Day < 10) r_date += "0";
            r_date += DateTime.Now.Day;
            string SQL_Code = "INSERT INTO tabmember VALUES('" + r_account + "','" + r_email + "','" +  r_name + "','" + r_gender + "','" + r_phone + "','" +  r_date + "', " +r_admin + ")";
            Submit_Tsql_NonQuery(SQL_Code);
        }

        public void Update_1_Tsql_UpdateTabBook(int index, string[] _bookdata)
        {


            string SQL_Code = "UPDATE tabbook set ";
            string[] SQL_setname = new string[7] { "名稱", "作者", "出版社", "出版日期", "價格", "ISBN", "分類" };

            for (int i = 0; i < 7; i++)
            {
                SQL_Code += SQL_setname[i] + " = '" + _bookdata[i] + "'";
                if (i != 6) SQL_Code += ",";
            }

            SQL_Code += " where 編號 = " + index.ToString();
            Submit_Tsql_NonQuery(SQL_Code);
            MessageBox.Show("修改完成");
        }

        public void Delete_1_Tsql_DeleteTabBook(int index)
        {
            string SQL_Code = "DELETE FROM tabbook WHERE 編號 = " + index.ToString();
            Submit_Tsql_NonQuery(SQL_Code);
        }

        //----------------------------------------------------------------------------------------
        public void Submit_Tsql_NonQuery(string tsqlSourceCode)
        {
            try
            {
                using (var connection = new MySqlConnection(myConnectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(tsqlSourceCode, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(MySqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        public object SelectDataSource(string SQL_Code)
        {
            using (var connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(SQL_Code, connection);
                DataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
