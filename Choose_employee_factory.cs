using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace Hospital_project
{
   public  class Choose_employee_factory
    {
        public Form Create_form(Employee_choice c,int id)
        {
            if (c == Employee_choice.update_employee)
                return new Update_employee(id);
            else
            {
                if ((id / 1000) == 10 || (id / 1000) == 11)
                    return new Employee_View(id, new Doctor_View_strategy());
                else
                    return new Employee_View(id, new Employee_View_strategy());
            }
        }
    }
}
