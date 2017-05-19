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
        public int Add_new_appointment(DateTime date,string time,string status,int patient_id,int doctor_id)
        {
            string query = "INSERT INTO Appointments (Date,Time,Status,Patient_id,Doctor_id) VALUES ("+
                "'" + date.ToString("yyyy-MM-dd") + "'," +
                "'" + time + "'," +
                "'" + status + "'," +
                "" + patient_id + "," +
                "" +doctor_id + "" +
                ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Add_new_patient(string f_name,string m_name,string l_name,int id,string e_mail,DateTime date,string sex)
        {
            string query = "INSERT INTO Patient (F_name,M_name,L_name,ID,E_mail,Birthdate,Sex) VALUES ("+
               "'" + f_name + "'," +
                "'" + m_name + "'," +
                "'" + l_name + "'," +
                "" + id + "," +
                "'" + e_mail + "'," +
                "'" + date.ToString("yyyy-MM-dd") + "'," +
                 "'" + sex + "'" +            
                ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public int update_appointment(string time,string status,DateTime date,int patient_id,int doctor_id)
        {
            string query = "UPDATE Appointments SET" + " " +
                "Time=" + "'" + time + "'," +
                "Status=" + "'" + status + "'," +
                "Date=" + "'" + date.ToString("yyyy-MM-dd") + "'" +
                "Where Patient_id=" + patient_id +
                "and Doctor_id=" + doctor_id;
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
        public string patient_name(int id)
        {
            string query = "Select (F_name+' '+M_name+' '+L_name)AS Name from Patient where ID="+ id;
            return (string)dbMan.ExecuteScalar(query);
        }
        public DataTable get_doctors(string major)
        {
            string query = "Select User_name,(F_name+' '+M_name+' '+L_name)AS Name from Employee,Doctor_major where User_name !=1 and Doctor_id=User_name and Major=" + "'" + major + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable doctors_names()
        {
            string query="Select User_name,(F_name+' '+M_name+' '+L_name)AS Name from Employee where (User_name/1000)=11 or (User_name/1000)=10";
            return dbMan.ExecuteReader(query);
        }
        public DataTable doctor_schedule(int id)
        {
            string query = "select DAY,Start_time,End_time from Doctor_schedule where Doctor_id=" + id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable schedule_strategy(int id)
        {
            string query = "Select (F_name+' '+M_name+' '+L_name)AS Name, DAY,Start_time,End_time from Employee,Doctor_schedule where Doctor_id=" + id +
                "and User_name="+id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable information_stategy(int id)
        {
            string query = "Select (F_name+' '+M_name+' '+L_name)AS Name,Phone,E_mail from Employee where User_name="+id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable View_appointment()
        {
            string query = "select (Employee.F_name+' '+Employee.M_name+' '+Employee.L_name) AS Doctor_Name,(Patient.F_name+' '+Patient.M_name+' '+Patient.L_name) AS Patient_Name,Date,Time,Status from Employee,Patient,Appointments where Doctor_id=User_name and Patient_id=ID";
            return dbMan.ExecuteReader(query);
        }
        public int delete_appointments()
        {
            string query = "Delete from Appointments where Status='finish'";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
