using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Hospital_project
{
   public class Information_Strategy:View_Strategy
    {
       Receptionist_Controller control_object;
       public Information_Strategy()
       {
           control_object = new Receptionist_Controller();
       }
       public override DataTable View_operation(int id)
       {
           DataTable dt = control_object.information_stategy(id);
           return dt;
       }
    }
}
