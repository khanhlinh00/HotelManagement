using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace Data_Access
{
    public class EmployeeDAO : BaseDAL
    {
        private static EmployeeDAO instance = null;
        private static readonly object instnaceLock = new object();
        private EmployeeDAO() { }
        public static EmployeeDAO Instance
        {
            get
            {
                lock (instnaceLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeDAO();
                    }
                    return instance;
                }
            }
        }
        public EmployeeObject Login(string username, string password)
        {
            EmployeeObject employee = null;
            IDataReader dataReader = null;
            try
            {
                string SQLSelect = "Select EmployeeID, EmployeeName, PathImage, username, password from Employee where username = @username AND password=@password";
                var parameters = new List<SqlParameter>();
                parameters.Add(DataProvider.CreateParameter("@username", 50, username, DbType.String));
                parameters.Add(DataProvider.CreateParameter("@password", 30, password, DbType.String));
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());

                if (dataReader.Read())
                {
                    employee = new EmployeeObject
                    {
                        EmployeeID = dataReader.GetInt32(0),
                        EmployeeName = dataReader.GetString(1),
                        PathImage = dataReader.GetString(2),
                        username = dataReader.GetString(3),
                        password = dataReader.GetString(4),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return employee;
        }

        //-----------------------------------------------------------------------
        public List<EmployeeObject> GetEmloyeeList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select EmployeeID, EmployeeName, PathImage, username, password from Employee";
            var members = new List<EmployeeObject>();
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new EmployeeObject
                    {
                        EmployeeID = dataReader.GetInt32(0),
                        EmployeeName = dataReader.GetString(1),
                        PathImage = dataReader.GetString(2),
                        username = dataReader.GetString(3),
                        password = dataReader.GetString(4),
                        
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
    }
}
