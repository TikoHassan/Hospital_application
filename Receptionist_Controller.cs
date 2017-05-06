using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Hospital_project
{
    class Receptionist_Controller
    {
        DBManager dbMan;
        public Receptionist_Controller()
        {
            dbMan = DBManager.get_instnace();
        }
        public int Add_new_appointment()
        {
            string query = "";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable get_major()
        {
            string query = "select distinct Major from Doctor_Major";
            return dbMan.ExecuteReader(query);
        }
        public DataTable get_appointments(string major)
        {
            string query = "select  F_name,M_name,L_name,Start_time,End_time,DAY from Employee,Doctor_schedule,Doctor_Major where Major="+"'"+major+"'"+
                "and Doctor_Major.Doctor_id=User_name and Doctor_schedule.Doctor_id=User_name";
            return dbMan.ExecuteReader(query);
        }
        public DataTable get_doctors(string major)
        {
            string query = "Select User_name,(F_name+' '+M_name+' '+L_name)AS Name from Employee,Doctor_major where User_name !=1 and Doctor_id=User_name and Major=" + "'" + major + "'";
            return dbMan.ExecuteReader(query);
        }
    }
}
