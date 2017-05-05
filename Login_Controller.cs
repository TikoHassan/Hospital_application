using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Hospital_project
{
    public class  Login_Controller
    {
        DBManager dbMan;
        public Login_Controller()
        {
            dbMan =DBManager.get_instnace();
        }
        public int login(int id,string password)
        {
            string query = "Select User_name from Employee where User_name=" + id + "and Password= '"+password+"'";
            object ID=dbMan.ExecuteScalar(query);
            if (ID == null)
                return 0;
            else
                return (int)ID;
        }
        public string Employee_fname(int id)
        {
            string query = "Select F_name from Employee where User_name=" + id;
            object name = dbMan.ExecuteScalar(query);
            return (string)name;
        }
        
        public string get_user_password(long s_number)
        {
            string query = "Select Password from Employee where Security_number=" + s_number;
            object pass = dbMan.ExecuteScalar(query);
            return (string)pass;
        }
        public int get_user_id(long s_number)
        {
            string query="Select User_name from Employee where Security_number=" + s_number;
            object us = dbMan.ExecuteScalar(query);
            if (us == null)
                return 0;
            return (int)us;
        }
    

    }
}
