using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SMMC.Models
{
    public class RosterDataAccessLayer
    {
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";

        //To View roster    
        public IEnumerable<Roster> GetRoster()
        {
            List<Roster> lstRoster = new List<Roster>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetRoster", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Roster roster = new Roster
                    {
                        RosterID = Convert.ToInt32(reader["RosterID"]),
                        Firstname = reader["firstName"].ToString(),
                        Surname = reader["surname"].ToString(),
                        LessonName = reader["LessonName"].ToString(),
                        StartTime = reader["StartTime"].ToString(),
                        Size = Convert.ToInt32(reader["Size"]),
                        EnsemblesName = reader["EnsemblesName"].ToString(),
                        RosterDate = Convert.ToDateTime(reader["RosterDate"])
                    };

                    lstRoster.Add(roster);
                }
                con.Close();
            }
            return lstRoster;

        }


        //To View all tutors    
        public IEnumerable<Roster> GetTutors()
        {
            List<Roster> lstTutors = new List<Roster>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetTutorsList", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Roster tutors = new Roster
                    {
                        PersonID = Convert.ToInt32(reader["personID"]),
                        Firstname = reader["firstname"].ToString(),
                        Surname = reader["surname"].ToString(),
                        Skill = Convert.ToInt32(reader["skill"]),
                        Role = reader["role"].ToString()
                    };

                    lstTutors.Add(tutors);
                }
                con.Close();
            }
            return lstTutors;

        }

        //To View all lessons    
        public IEnumerable<Roster> GetLesson()
        {
            List<Roster> lstLesson = new List<Roster>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetLessonList", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Roster lessons = new Roster
                    {
                        LessonID = Convert.ToInt32(reader["LessonID"]),
                        LessonName = reader["name"].ToString(),
                        LessonDate = Convert.ToDateTime(reader["Date"]),
                        StartTime = reader["StartTime"].ToString()
                    };

                    lstLesson.Add(lessons);
                }
                con.Close();
            }
            return lstLesson;

        }

        //To View all ensembles
        public IEnumerable<Roster> GetEnsembles()
        {
            List<Roster> lstensembles = new List<Roster>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetEnsembles", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Roster ensembles = new Roster
                    {
                        EnsemblesID = Convert.ToInt32(rdr["ensemblesID"]),
                        EnsemblesName = rdr["EnsemblesName"].ToString()
                    };

                    lstensembles.Add(ensembles);
                }
                con.Close();
            }
            return lstensembles;
        }

        //To Add new roster record    
        public void AddRoster(Roster roster)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddRoster", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", roster.PersonID);
                cmd.Parameters.AddWithValue("@lessonID", roster.LessonID);
                cmd.Parameters.AddWithValue("@ensemblesID", roster.EnsemblesID);
                cmd.Parameters.AddWithValue("@rosterDate", roster.RosterDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Update the records of a particluar roster  
        public void UpdateRoster(Roster roster)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateRoster", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@rosterID", roster.RosterID);
                cmd.Parameters.AddWithValue("@personID", roster.PersonID);
                cmd.Parameters.AddWithValue("@lessonID", roster.LessonID);
                cmd.Parameters.AddWithValue("@ensemblesID", roster.EnsemblesID);
                cmd.Parameters.AddWithValue("@rosterDate", roster.RosterDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Delete the record on a particular roster  
        public void DeleteRoster(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteRoster", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@rosterID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Get the details of a particular roster  
        public Roster GetRosterData(int? id)
        {
            Roster roster = new Roster();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT Roster.rosterID as [RosterID], " +
                    "Person.firstname as [firstname] , " +
                    "Person.surname as [surname], " +
                    "Lesson.lessonName as [LessonName], " +
                    "Lesson.startTime as [StartTime], " +
                    "lesson.size as [Size], " +
                    "Ensembles.ensemblesName as [EnsemblesName], " +
                    "Roster.rosterDate as [RosterDate] " +
                    "FROM Lesson " +
                    "JOIN Roster ON Lesson.lessonID = Roster.lessonID " +
                    "JOIN Person  ON Person.personID = Roster.personID " +
                    "JOIN Ensembles ON Roster.ensemblesID = Ensembles.ensemblesID " +
                    "WHERE Roster.rosterID = " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    roster.RosterID = Convert.ToInt32(rdr["rosterID"]);
                    roster.Firstname = rdr["firstname"].ToString();
                    roster.Surname = rdr["surname"].ToString();
                    roster.LessonName = rdr["LessonName"].ToString();
                    roster.StartTime = rdr["StartTime"].ToString();
                    roster.Size = Convert.ToInt32(rdr["Size"]);
                    roster.EnsemblesName = rdr["EnsemblesName"].ToString();
                    roster.RosterDate = Convert.ToDateTime(rdr["RosterDate"]);
                }
            }
            return roster;
        }
    }
}
