using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMMC.Models
{
    public class EnsemblesDataAccessLayer
    {
        //string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";

        //To View all Ensembles details    
        public IEnumerable<Ensembles> GetAllEnsembles()
        {
            List<Ensembles> listensemble = new List<Ensembles>();

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
                    Ensembles ensembles = new Ensembles
                    {

                        EnsembleID = Convert.ToInt32(reader["ensemblesID"]),
                        EnsembleName = reader["ensemblesName"].ToString(),
                        
                    };

                    listensemble.Add(ensembles);
                }
                con.Close();
            }
            return listensemble;
        }


        //To Add new ensembles record    
        public void AddEnsembles(Ensembles ensembles)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEnsembles", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ensemblesName", ensembles.EnsembleName);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Update the records of a particluar ensembles  
        public void UpdateEnsembles(Ensembles ensembles)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEnsembles", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ensemblesID", ensembles.EnsembleID);
                cmd.Parameters.AddWithValue("@ensemblesName", ensembles.EnsembleName);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Delete the record on a particular ensembles  
        public void DeleteEnsembles(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEnsembles", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@ensemblesID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //Get the details of a particular instrument  
        public Ensembles GetEnsemblesData(int? id)
        {
            Ensembles ensembles = new Ensembles();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT ensemblesID, ensemblesName FROM dbo.Ensembles WHERE ensemblesID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ensembles.EnsembleID = Convert.ToInt32(rdr["ensemblesID"]);
                    ensembles.EnsembleName = rdr["ensemblesName"].ToString();
                }
            }
            return ensembles;
        }

    }
}
