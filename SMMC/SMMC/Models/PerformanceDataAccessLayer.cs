using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMMC.Models
{
    public class PerformanceDataAccessLayer
    {
        //string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";

        //To View all performances details    
        public IEnumerable<Performance> GetAllPerformances()
        {
            List<Performance> lstperformance = new List<Performance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetPerformance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Performance performance = new Performance
                    {
                        PerformanceID = Convert.ToInt32(rdr["performanceID"]),
                        PerformanceType = rdr["PerformanceType"].ToString(),
                        PerformanceTitle = rdr["PerformanceTitle"].ToString(),
                        EnsemblesName = rdr["EnsemblesName"].ToString(),
                        Venue = rdr["Venue"].ToString(),
                        PerformanceDate = Convert.ToDateTime(rdr["PerformanceDate"])
                    };

                    lstperformance.Add(performance);
                }
                con.Close();
            }
            return lstperformance;
        }


        //To View all performances for students    
        public IEnumerable<Performance> GetPersonPerformance()
        {
            List<Performance> lstpersonperformance = new List<Performance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetPersonPerformance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Performance performance = new Performance
                    {
                        PerformanceID = Convert.ToInt32(rdr["performanceID"]),
                        Firstname = rdr["firstname"].ToString(),
                        Surname = rdr["surname"].ToString(),
                        EnsemblesName = rdr["EnsemblesName"].ToString(),
                        PerformanceTitle = rdr["PerformanceTitle"].ToString(),
                        PerformanceType = rdr["PerformanceType"].ToString(),
                        Venue = rdr["Venue"].ToString(),
                        PerformanceDate = Convert.ToDateTime(rdr["PerformanceDate"])
                    };

                    lstpersonperformance.Add(performance);
                }
                con.Close();
            }
            return lstpersonperformance;
        }

        //To View all enrolments   
        public IEnumerable<Performance> GetEnrolment()
        {
            List<Performance> lstenrolment = new List<Performance>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetEnrolment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Performance enrolment = new Performance
                    {
                        EnrolmentID = Convert.ToInt32(rdr["EnrolmentID"]),
                        Firstname = rdr["Firstname"].ToString(),
                        Surname = rdr["Surname"].ToString()
                    };

                    lstenrolment.Add(enrolment);
                }
                con.Close();
            }
            return lstenrolment;
        }


        //To View all ensembles
        public IEnumerable<Performance> GetEnsembles()
        {
            List<Performance> lstensembles = new List<Performance>();

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
                    Performance ensembles = new Performance
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


        //To Add new performance record    
        public void AddPerformance(Performance performance)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddPerformance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@performanceType", performance.PerformanceType);
                cmd.Parameters.AddWithValue("@performanceTitle", performance.PerformanceTitle);
                cmd.Parameters.AddWithValue("@ensemblesID", performance.EnsemblesID);
                cmd.Parameters.AddWithValue("@venue", performance.Venue);
                cmd.Parameters.AddWithValue("@performanceDate", performance.PerformanceDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        //To Update the records of a particluar performance  
        public void UpdatePerformance(Performance performance)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdatePerformance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@performanceID", performance.PerformanceID);
                cmd.Parameters.AddWithValue("@performanceType", performance.PerformanceType);
                cmd.Parameters.AddWithValue("@performanceTitle", performance.PerformanceTitle);
                cmd.Parameters.AddWithValue("@ensemblesID", performance.EnsemblesID);
                cmd.Parameters.AddWithValue("@venue", performance.Venue);
                cmd.Parameters.AddWithValue("@performanceDate", performance.PerformanceDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Delete the record on a particular performance  
        public void DeletePerformance(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeletePerformance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@performanceID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Get the details of a particular performance  
        public Performance GetPerformanceData(int? id)
        {
            Performance performance = new Performance();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT performanceID, " +
                    "performanceType as [PerformanceType], " +
                    "performanceTitle as [PerformanceTitle], " +
                    "Ensembles.ensemblesName as [EnsemblesName], " +
                    "Performance.venue as [Venue], " +
                    "Performance.performanceDate as [PerformanceDate] " +
                    "FROM Performance " +
                    "JOIN Ensembles ON Performance.ensemblesID = Ensembles.ensemblesID " +
                    "WHERE performanceID = " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    performance.PerformanceID = Convert.ToInt32(rdr["performanceID"]);
                    performance.PerformanceType = rdr["PerformanceType"].ToString();
                    performance.PerformanceTitle = rdr["PerformanceTitle"].ToString();
                    performance.EnsemblesName = rdr["EnsemblesName"].ToString();
                    performance.Venue = rdr["Venue"].ToString();
                    performance.PerformanceDate = Convert.ToDateTime(rdr["PerformanceDate"]);
                }
            }
            return performance;
        }

    }
}
