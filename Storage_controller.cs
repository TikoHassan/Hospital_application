using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace Hospital_project
{
    public class Storage_controller
    {
        DBManager dbMan;
        public Storage_controller()
        {
            dbMan = DBManager.get_instnace();
        }
        public DataTable view_storage_info()
        {
            string query = "Select Name,Type,ID,Amount,F_name,M_name,L_name from Medical_Storage,Employee where Emp_id=User_name";
            return dbMan.ExecuteReader(query);
        }
        public int Add_Storage(string name, string type, int amount, int id, int emp_id)
        {
            string query = "INSERT INTO Medical_Storage(Name,Type,ID,Amount,Emp_id) Values(" +
                "'" + name + "'," +
                "'" + type + "'," +
                "" + id + "," +
                "" + amount + "," +
                "" + emp_id + ""
                + ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable get_medicine_name()
        {
            string query = "Select Name,ID from Medical_Storage";
            return dbMan.ExecuteReader(query);
        }
        public int Delete_row(int id)
        {
            string query = "Delete from Medical_Storage where ID=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int update_storage(int id, int amount)
        {
            string query = "UPDATE Medical_Storage SET" + " " +
                "Amount=" + "" + amount + "" + "Where ID=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int set_storage_man(int id)
        {
            string query = "UPDATE Medical_Storage SET" + " " +
                "Emp_id=" + 1 + "Where Emp_id=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
