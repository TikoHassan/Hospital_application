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
    }
}
