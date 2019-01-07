using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMMC.Models
{
    public class EnrolmentDataAccessLayer : Controller
    {
        //string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";

        //To View all Enrolment details    
        public IEnumerable<Enrolment> GetAllEnrolment()
        {
            List<Enrolment> listEnrolment = new List<Enrolment>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetEnrolment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Enrolment enrolment = new Enrolment
                    {
                        PersonID = Convert.ToInt32(reader["personID"]),
                        EnrolmentID = Convert.ToInt32(reader["EnrolmentID"]),
                        Firstname = reader["Firstname"].ToString(),
                        Surname = reader["Surname"].ToString(),
                        Skill = reader["Skill"].ToString(),
                        EnsemblesID = Convert.ToInt32(reader["ensemblesID"]),
                        EnsembleName = reader["Ensembles name"].ToString(),
                        LessonID = Convert.ToInt32(reader["lessonID"]),
                        LessonName = reader["Lesson Name"].ToString(),
                        Instrument = reader["instrument"].ToString(),
                        Date = Convert.ToDateTime(reader["Date"]),
                    };

                    listEnrolment.Add(enrolment);
                }
                con.Close();
            }
            return listEnrolment;
        }

        //To View all Student details    
        public IEnumerable<Enrolment> GetStudents()
        {
            List<Enrolment> listEnrolment = new List<Enrolment>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetStudent", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Enrolment enrolment = new Enrolment
                    {
                        PersonID = Convert.ToInt32(reader["personID"]),
                        Firstname = reader["firstname"].ToString(),
                        Surname = reader["surname"].ToString(),
                        Skill = reader["skill"].ToString(),

                    };

                    listEnrolment.Add(enrolment);
                }
                con.Close();
            }
            return listEnrolment;
        }


        //To View all Lesson details    
        public IEnumerable<Enrolment> GetLesson()
        {
            List<Enrolment> listEnrolment = new List<Enrolment>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetLesson", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Enrolment enrolment = new Enrolment
                    {
                        LessonID = Convert.ToInt32(reader["LessonID"]),
                        LessonName = reader["name"].ToString(),
                        Instrument = reader["Instrument"].ToString(),
                        Start = reader["StartTime"].ToString(),


                    };

                    listEnrolment.Add(enrolment);
                }
                con.Close();
            }
            return listEnrolment;

        }

        //To View all Ensembles details    
        public IEnumerable<Enrolment> GetEnsembles()
        {
            List<Enrolment> listEnrolment = new List<Enrolment>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetEnsembles", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Enrolment enrolment = new Enrolment
                    {
                        EnsemblesID = Convert.ToInt32(reader["ensemblesID"]),
                        EnsembleName = reader["ensemblesName"].ToString(),

                    };

                    listEnrolment.Add(enrolment);
                }
                con.Close();
            }
            return listEnrolment;

        }

        //Add Information to enrolment
        public void AddEnrolment(Enrolment enrolment)
        {
 
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEnrolment2", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", enrolment.PersonID);
                cmd.Parameters.AddWithValue("@lessonID", enrolment.LessonID);
                cmd.Parameters.AddWithValue("@ensemblesID", enrolment.EnsemblesID);
                cmd.Parameters.AddWithValue("@enrolmentDate", enrolment.Date);
                cmd.Parameters.AddWithValue("@enrolLessonID", enrolment.LessonID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }

        //To Update the records of a particluar Enrolment  
        public void UpdateEnrolment(Enrolment enrolment)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEnrolment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@enrolmentID", enrolment.EnrolmentID);
                cmd.Parameters.AddWithValue("@personID", enrolment.PersonID);
                cmd.Parameters.AddWithValue("@lessonID", enrolment.LessonID);
                cmd.Parameters.AddWithValue("@ensemblesID", enrolment.EnsemblesID);
                cmd.Parameters.AddWithValue("@enrolmentDate", enrolment.Date);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Delete the record on a particular Enrolment  
        public void DeleteEnrolment(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEnrolment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@enrolmentID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Get the details of a particular Enrolment  
        public Enrolment GetEnrolmentData(int? id)
        {
            Enrolment enrolment = new Enrolment();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT Enrolment.enrolmentID as [EnrolmentID], " +
                    "Enrolment.enrolmentDate as [Date], " +
                    "Person.personID as [personID], " +
                    "Person.firstname as [Firstname] , " +
                    "Person.surname as [Surname] , " +
                    "Person.skill as [Skill], " +
                    "Lesson.lessonID as [lessonID], " +
                    "Lesson.lessonName as [Lesson Name], " +
                    "Instrument.instrumentName as [instrument], " +
                    "Ensembles.ensemblesID as [ensemblesID], " +
                    "Ensembles.ensemblesName as [Ensembles name] " +
                    "FROM Enrolment " +
                    "JOIN Person  ON Person.personID = Enrolment.personID " +
                    "JOIN Lesson on Lesson.lessonID = Enrolment.lessonID " +
                    "JOIN Instrument ON Lesson.instrumentID = Instrument.instrumentID " +
                    "JOIN Ensembles on Enrolment.ensemblesID = Ensembles.ensemblesID " +
                    "WHERE Enrolment.enrolmentID = " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    enrolment.EnrolmentID = Convert.ToInt32(rdr["EnrolmentID"]);
                    enrolment.PersonID = Convert.ToInt32(rdr["personID"]);
                    enrolment.Firstname = rdr["FirstName"].ToString();
                    enrolment.Surname = rdr["Surname"].ToString();
                    enrolment.Skill = rdr["Skill"].ToString();
                    enrolment.EnsemblesID = Convert.ToInt32(rdr["ensemblesID"]);
                    enrolment.EnsembleName = rdr["Ensembles name"].ToString();
                    enrolment.LessonID = Convert.ToInt32(rdr["lessonID"]);
                    enrolment.LessonName = rdr["Lesson Name"].ToString();
                    enrolment.Instrument = rdr["instrument"].ToString();
                    enrolment.Date = Convert.ToDateTime(rdr["Date"]);
                }
            }
            return enrolment;
        }
    }
}
