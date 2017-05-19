using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace Hospital_project
{
    public class Schedule_view_strategy:View_Strategy
    {
        Receptionist_Controller control_object;
       public Schedule_view_strategy()
        {
            control_object = new Receptionist_Controller();
        }
       public override DataTable View_operation(int id)
       {
           DataTable dt = control_object.schedule_strategy(id);
           return dt;
       }
    }
}
