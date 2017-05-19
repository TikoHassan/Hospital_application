using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

 public enum Employee_choice
{
    update_employee,
    view_employee
};

public enum Function
{
    view_patient,
    finish_appointment
};

namespace Hospital_project
{
    class Doctor_controller
    {
        DBManager dbMan;
        public Doctor_controller()
        {
            dbMan = DBManager.get_instnace();
        }
        public int Add_new_employee(string f_name,string m_name,string l_name,int us,string pass,int wage,string sex,
            string email,long phone,string Address,DateTime st,long sn)
        {
            string query = "INSERT INTO Employee (F_name,M_name,L_name,User_name,Password,Wage,Sex,E_mail,Phone,Address,Start_Date,Security_number) VALUES (" +
                "'" + f_name + "'," +
                "'" + m_name + "'," +
                "'" + l_name + "'," +
                "" + us + "," +
                "'" + pass + "'," +
                "" + wage + "," +
                "'" + sex + "'," +
                "'" + email + "'," +
                "" + phone + "," +
                "'" + Address + "'," +
                "'" + st.ToString("yyyy-MM-dd") + "'," +
                "" + sn + "" +
                ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Add_major(int id, string major)
        {
            string query = "INSERT INTO Doctor_Major (Doctor_id,Major) VALUES("+""+id+","+"'"+major+"'"+")";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable get_employees()
        {
            string query = "Select User_name,(F_name+' '+M_name+' '+L_name)AS Name from Employee where User_name !=1";
            return dbMan.ExecuteReader(query);
        }
        public int Update_employee(int id,string email,string Address,long phone,int wage)
        {
            string query = "UPDATE Employee SET"+" "+
                "E_mail="+"'"+email+"',"+
                "Address="+"'"+Address+"',"+
                "Phone="+""+phone+","+
                "Wage="+""+wage+""+
                "Where User_name="+id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int fire_employee(int id)
        {
            string query = "Delete from Employee where User_name=" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable view_all_emloyees()
        {
            string query = "Select F_name,M_name,L_name,(User_name/1000),E_mail,Phone,Sex,Wage,Start_Date,Address from Employee where User_name !=1";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Strategy1(int id)
        {
            string query = "Select F_name,M_name,L_name,(User_name/1000),Major,E_mail,Phone,Sex,Wage,Start_Date,Address from Employee,Doctor_Major where User_name="
                + id + "and Doctor_id=User_name";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Strategy2(int id)
        {
            string query = "Select F_name,M_name,L_name,(User_name/1000),E_mail,Phone,Sex,Wage,Start_Date,Address from Employee where User_name=" + id;
            return dbMan.ExecuteReader(query);
        }
        public int finish_appointment(int Doctor_id, int patient_id)
        {
            string query = "UPDATE Appointments SET Status='finish' where Doctor_id=" + Doctor_id + "and Patient_id=" + patient_id;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Patient_info(int id)
        {
            string query = "select (F_name+' '+M_name+' '+L_name)AS Name,E_mail,Birthdate,Sex from Patient where ID="+id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable patient_diseases(int id)
        {
            string query = "select Disease from [Patient's_disease] where Patient_id="+id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable medicine_taken(int id)
        {
            string query = "select Medicine from [Patient's_Medicine] where Patient_id=" + id;
            return dbMan.ExecuteReader(query);
        }
    }
}
