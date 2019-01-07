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
    public class LessonDataAccessLayer 
    {
        //string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";

        //To View all Lesson details    
        public IEnumerable<Lesson> GetAllLessons()
        {
            List<Lesson> listlesson = new List<Lesson>();

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
                    Lesson lesson = new Lesson
                    {
                        LessonID = Convert.ToInt32(reader["LessonID"]),
                        LessonName = reader["name"].ToString(),
                        Size = Convert.ToInt32(reader["size"]),
                        Date = Convert.ToDateTime(reader["date"]),
                        Time = reader["StartTime"].ToString(),                     
                        Instrument = reader["instrument"].ToString()                  
                    };

                    listlesson.Add(lesson);
                }
                con.Close();
            }
            return listlesson;
        }

        //To View student Lesson details    
        public IEnumerable<Lesson> GetStudentLessons()
        {
            List<Lesson> listlesson = new List<Lesson>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetLessonInfo", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Lesson lesson = new Lesson
                    {

                        LessonName = reader["Lesson Name"].ToString(),
                        count = Convert.ToInt32(reader["Students in Lesson"]),

                    };

                    listlesson.Add(lesson);
                }
                con.Close();
            }
            return listlesson;
        }


        //To View all instruments details    
        public IEnumerable<Lesson> GetAllInstruments()
        {
            List<Lesson> lstinstrument = new List<Lesson>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetInstrument", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Lesson instrument = new Lesson
                    {
                        InstrumentID = Convert.ToInt32(rdr["instrumentID"]),
                        Instrument = rdr["instrumentName"].ToString()
                    };

                    lstinstrument.Add(instrument);
                }
                con.Close();
            }
            return lstinstrument;
        }

        //Add Lesson
        public void LessonAdd(Lesson lesson)
        {
            //int id = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddLesson", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@lessonName", lesson.LessonName);
                cmd.Parameters.AddWithValue("@instrumentID", lesson.InstrumentID);
                cmd.Parameters.AddWithValue("@startTime", lesson.Time);
                cmd.Parameters.AddWithValue("@size", lesson.Size);
                cmd.Parameters.AddWithValue("@lessonDate", lesson.Date);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
           
        }

        //To Update the records of a particluar Lesson  
        public void UpdateLesson(Lesson lesson)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateLesson", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@lessonID", lesson.LessonID);
                cmd.Parameters.AddWithValue("@lessonName", lesson.LessonName);
                cmd.Parameters.AddWithValue("@instrumentID", lesson.InstrumentID);
                cmd.Parameters.AddWithValue("@startTime", lesson.Time);
                cmd.Parameters.AddWithValue("@size", lesson.Size);
                cmd.Parameters.AddWithValue("@lessonDate", lesson.Date);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Delete the record on a particular Lesson  
        public void DeleteLesson(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteLesson", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@lessonID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Get the details of a particular Lesson  
        public Lesson GetLessonData(int? id)
        {
            Lesson lesson = new Lesson();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT Lesson.lessonName as [name], " +
                    "Lesson.lessonID as [LessonID], " +
                    "Lesson.lessonDate as [Date], " +
                    "Lesson.size as [size], " +
                    "Lesson.startTime as [StartTime], " +
                    "Instrument.instrumentName as [Instrument] " +
                    "FROM Lesson " +
                    "JOIN Instrument ON Instrument.instrumentID = Lesson.instrumentID " +
                    "WHERE Lesson.lessonID = " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lesson.Size = Convert.ToInt32(rdr["size"]);
                    lesson.LessonID = Convert.ToInt32(rdr["LessonID"]);
                    lesson.Time = rdr["StartTime"].ToString();
                    lesson.LessonName = rdr["name"].ToString();
                    lesson.Instrument = rdr["Instrument"].ToString();
                    lesson.Date = Convert.ToDateTime(rdr["Date"]);
                }
            }
            return lesson;
        }
    }
}
