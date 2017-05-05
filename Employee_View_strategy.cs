using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Hospital_project
{
    public class Employee_View_strategy:View_Strategy
    {
        Doctor_controller c;
        public Employee_View_strategy()
        {
            c = new Doctor_controller();
        }
        public override DataTable View_operation(int id)
        {
            DataTable dt = c.Strategy2(id);
            return dt;
        }
    }
}
