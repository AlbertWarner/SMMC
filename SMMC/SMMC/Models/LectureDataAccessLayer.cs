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
    public class LectureDataAccessLayer 
    {
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";

        //To View all Lecture details    
        public IEnumerable<Lecture> GetAllLectures()
        {
            List<Lecture> listLecture = new List<Lecture>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetTutors", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Lecture lecture = new Lecture
                    {
                        personID = Convert.ToInt32(reader["personID"]),
                        Firstname = reader["FirstName"].ToString(),
                        Surname = reader["Surname"].ToString(),
                        skill = reader["skill"].ToString(),
                        role = reader["role"].ToString(),
                        salary = Convert.ToDecimal(reader["salary"]),
                        phone = reader["phone"].ToString(),
                        email = reader["emailAddress"].ToString()
                    };

                    listLecture.Add(lecture);
                }
                con.Close();
            }
            return listLecture;
        }

        //Get the details of a particular Lecture  
        public Lecture GetLectureData(int? personID)
        {
            Lecture lecture = new Lecture();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Person WHERE personID =" + personID;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lecture.personID = Convert.ToInt32(reader["personID"]);
                    lecture.Firstname = reader["FirstName"].ToString();
                    lecture.Surname = reader["Surname"].ToString();
                    lecture.skill = reader["skill"].ToString();
                    lecture.role = reader["role"].ToString();
                    lecture.salary = Convert.ToDecimal(reader["salary"]);
                }
            }
            return lecture;
        }


        //Get the details of a particular Lecture  
        public Lecture GetLectureContactData(int? personID)
        {
            Lecture lecture = new Lecture();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Contact WHERE personID =" + personID;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lecture.personID = Convert.ToInt32(reader["personID"]);
                    lecture.phone = reader["phone"].ToString();
                    lecture.email = reader["emailAddress"].ToString();
                }
            }
            return lecture;
        }

        //Get the details of a particular Lecture  
        public Lecture GetQualification(int? qualificationTypeID)
        {
            Lecture lecture = new Lecture();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Qualifications_Type WHERE qualificationsTypeID =" + qualificationTypeID;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lecture.qualificationTypeID = Convert.ToInt32(reader["qualificationsTypeID"]);
                    lecture.qualificationType = reader["qualificationsName"].ToString();
                }
            }
            return lecture;
        }

        //To get Tutor for drop down    
        public IEnumerable<Lecture> GetLectureDRP()
        {
            List<Lecture> listLecture = new List<Lecture>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetTutors", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Lecture Lecture = new Lecture();
                    Lecture.personID = Convert.ToInt32(rdr["personID"]);
                    Lecture.Firstname = rdr["firstname"].ToString();
                    Lecture.Surname = rdr["surname"].ToString();
                    Lecture.skill = rdr["skill"].ToString();
                    //LectureQuali.role = rdr["role"].ToString();
                    //LectureQuali.qualificationTypeID = Convert.ToInt32(rdr["qualificationID"]);
                    //LectureQuali.qualificationType = rdr["Qualifications Type"].ToString();
                    //LectureQuali.instrument = rdr["instrument"].ToString();
                    //LectureQuali.instrumentID = Convert.ToInt32(rdr["instrumentID"]);


                    listLecture.Add(Lecture);
                }
                con.Close();
            }
            return listLecture;
        }

        //To get Instrument for drop down    
        public IEnumerable<Lecture> GetInstrumentDRP()
        {
            List<Lecture> instrument = new List<Lecture>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetInstrument", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Lecture instrumentTutor = new Lecture();
                    instrumentTutor.instrument = rdr["instrumentName"].ToString();
                    instrumentTutor.instrumentID = Convert.ToInt32(rdr["instrumentID"]);


                    instrument.Add(instrumentTutor);
                }
                con.Close();
            }
            return instrument;
        }

        //To get Tutor and their Qualifications   
        public IEnumerable<Lecture> GetLectureQualifications()
        {
            List<Lecture> listLectureQuali = new List<Lecture>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetTutorsQualification", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Lecture LectureQuali = new Lecture();
                    LectureQuali.personID = Convert.ToInt32(rdr["personID"]);
                    LectureQuali.Firstname = rdr["firstname"].ToString();
                    LectureQuali.Surname = rdr["surname"].ToString();
                    LectureQuali.skill = rdr["skill"].ToString();
                    LectureQuali.role = rdr["role"].ToString();
                    LectureQuali.qualificationTypeID = Convert.ToInt32(rdr["qualificationID"]);
                    LectureQuali.qualificationType = rdr["Qualifications Type"].ToString();
                    LectureQuali.instrument = rdr["instrument"].ToString();
                    LectureQuali.instrumentID = Convert.ToInt32(rdr["instrumentID"]);


                    listLectureQuali.Add(LectureQuali);
                }
                con.Close();
            }
            return listLectureQuali;
        }

        //Add Tutor to person
        public int AddLecture(Lecture lecture)
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddPerson", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@firstname", lecture.Firstname);
                cmd.Parameters.AddWithValue("@surname", lecture.Surname);
                cmd.Parameters.AddWithValue("@skill", lecture.skill);
                cmd.Parameters.AddWithValue("@role", lecture.role);
                cmd.Parameters.AddWithValue("@salary", lecture.salary);


                con.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            return id;
        }

        //To Add new person contact    
        public void AddContact(Lecture lecture, int? personID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddContact", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", personID);
                cmd.Parameters.AddWithValue("@phone", lecture.phone);
                cmd.Parameters.AddWithValue("@emailAddress", lecture.email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Add Qualification Type to Qualification
        public int AddQualificationType(Lecture lecture)
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddQualificationsType", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@qualificationsName", lecture.qualificationType);             

                con.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar()); //This allows to get the user id to store in variable
                con.Close();
            }
            return id;
        }

        //Add Qualification 
        public void AddQualifications(Lecture lecture, int? qualificationTypeID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddQualifications", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@qualificationsType", qualificationTypeID);
                cmd.Parameters.AddWithValue("@instrumentID", lecture.instrumentID);
                cmd.Parameters.AddWithValue("@personID", lecture.personID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }         
        }

        //Update Lecture to person
        public void UpdateLecture(Lecture lecture)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateLecture", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", lecture.personID);
                cmd.Parameters.AddWithValue("@firstname", lecture.Firstname);
                cmd.Parameters.AddWithValue("@surname", lecture.Surname);
                cmd.Parameters.AddWithValue("@skill", lecture.skill);
                cmd.Parameters.AddWithValue("@role", lecture.role);
                cmd.Parameters.AddWithValue("@salary", lecture.salary);


                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }

        //Update Contact
        public void UpdateContact(Lecture lecture)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateContact", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", lecture.personID);
                cmd.Parameters.AddWithValue("@phone", lecture.phone);
                cmd.Parameters.AddWithValue("@emailAddress", lecture.email);

                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }

        //Update Qualifcations
        public void UpdateQualifications(Lecture lecture)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateQualificationType", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@qualificationsTypeID", lecture.qualificationTypeID);
                cmd.Parameters.AddWithValue("@qualificationName", lecture.qualificationType);

                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }

        //To Delete the record on a particular Lecture  
        public void DeleteLecture(int? personID)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", personID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Delete Qualification  
        public void DeleteQualification(int? qualificationTypeID)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteQualification", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@qualificationsTypeID", qualificationTypeID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }




    }
}
