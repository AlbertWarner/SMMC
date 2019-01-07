using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMMC.Models
{
    public class PieceDataAccessLayer
    {
        //string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";

        //To View all piece    
        public IEnumerable<Piece> GetAllPiece()
        {
            List<Piece> lstpiece = new List<Piece>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetPiece", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Piece piece = new Piece
                    {
                        PieceID = Convert.ToInt32(rdr["pieceID"]),
                        Type = rdr["type"].ToString(),
                        Part = rdr["part"].ToString(),
                        License = rdr["license"].ToString(),
                        TotalCopies = Convert.ToInt32(rdr["totalCopies"]),
                        DistributedCopies = Convert.ToInt32(rdr["distributedCopies"]),
                        ReturnedCopies = Convert.ToInt32(rdr["returnedCopies"])
                    };

                    lstpiece.Add(piece);
                }
                con.Close();
            }
            return lstpiece;
        }


        //To View all pieces hire for student    
        public IEnumerable<Piece> GetEnrolmentPieceHire()
        {
            List<Piece> lstpiecehire = new List<Piece>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetPersonPieceHire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Piece piece = new Piece
                    {
                        PieceHireID = Convert.ToInt32(rdr["PieceHireID"]),
                        Firstname = rdr["firstname"].ToString(),
                        Surname = rdr["surname"].ToString(),
                        Type = rdr["Type"].ToString(),
                        Part = rdr["Part"].ToString(),
                        Returned = Convert.ToBoolean(rdr["Returned"]),
                        PieceHireDate = Convert.ToDateTime(rdr["PieceHireDate"])
                    };

                    lstpiecehire.Add(piece);
                }
                con.Close();
            }
            return lstpiecehire;
        }


        //To View all pieces hire for performance  
        public IEnumerable<Piece> GetPerformancePieceHire()
        {
            List<Piece> lstperformancepiecehire = new List<Piece>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetPiecePerformance", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Piece piece = new Piece
                    {
                        PieceHireID = Convert.ToInt32(rdr["PieceHireID"]),
                        Venue = rdr["Venue"].ToString(),
                        Type = rdr["Type"].ToString(),
                        Part = rdr["Part"].ToString(),
                        Returned = Convert.ToBoolean(rdr["Returned"]),
                        PerformanceDate = Convert.ToDateTime(rdr["PerformanceDate"])
                    };

                    lstperformancepiecehire.Add(piece);
                }
                con.Close();
            }
            return lstperformancepiecehire;
        }

        //To View all enrolments   
        public IEnumerable<Piece> GetEnrolment()
        {
            List<Piece> lstenrolment = new List<Piece>();

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
                    Piece enrolment = new Piece
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

        //To View all enrolments performance
        public IEnumerable<Piece> GetPerformance()
        {
            List<Piece> lstperformance = new List<Piece>();

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
                    Piece performance = new Piece
                    {
                        PerformanceID = Convert.ToInt32(rdr["performanceID"]),
                        Venue = rdr["Venue"].ToString(),
                        PerformanceDate = Convert.ToDateTime(rdr["PerformanceDate"])
                    };

                    lstperformance.Add(performance);
                }
                con.Close();
            }
            return lstperformance;
        }

        //To Add new piece record    
        public void AddPiece(Piece piece)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddPiece", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@type", piece.Type);
                cmd.Parameters.AddWithValue("@part", piece.Part);
                cmd.Parameters.AddWithValue("@license", piece.License);
                cmd.Parameters.AddWithValue("@totalCopies", piece.TotalCopies);
                cmd.Parameters.AddWithValue("@distributedCopies", piece.DistributedCopies);
                cmd.Parameters.AddWithValue("@returnedCopies", piece.ReturnedCopies);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Add new piece hire record    
        public void AddEnrolmentPieceHire(Piece piece)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEnrolmentPiece_Hire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                //cmd.Parameters.AddWithValue("@performanceID", piece.PerformanceID);
                cmd.Parameters.AddWithValue("@enrolmentID", piece.EnrolmentID);
                cmd.Parameters.AddWithValue("@pieceID", piece.PieceID);
                cmd.Parameters.AddWithValue("@returned", piece.Returned);
                cmd.Parameters.AddWithValue("@pieceHireDate", piece.PieceHireDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Add new piece hire record    
        public void AddPerformancePieceHire(Piece piece)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddPerformancePiece_Hire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@performanceID", piece.PerformanceID);
                //cmd.Parameters.AddWithValue("@enrolmentID", piece.EnrolmentID);
                cmd.Parameters.AddWithValue("@pieceID", piece.PieceID);
                cmd.Parameters.AddWithValue("@returned", piece.Returned);
                cmd.Parameters.AddWithValue("@pieceHireDate", piece.PieceHireDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particluar piece
        public void UpdatePiece(Piece piece)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdatePiece", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@pieceID", piece.PieceID);
                cmd.Parameters.AddWithValue("@type", piece.Type);
                cmd.Parameters.AddWithValue("@part", piece.Part);
                cmd.Parameters.AddWithValue("@license", piece.License);
                cmd.Parameters.AddWithValue("@totalCopies", piece.TotalCopies);
                cmd.Parameters.AddWithValue("@returnedCopies", piece.ReturnedCopies);
                cmd.Parameters.AddWithValue("@distributedCopies", piece.DistributedCopies);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Update the records of a particluar enrolment piece hire 
        public void UpdateEnrolmentPieceHire(Piece piece)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEnrolmentPieceHire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@pieceHireID", piece.PieceHireID);
                cmd.Parameters.AddWithValue("@returned", piece.Returned);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Update the records of a particluar performance piece hire 
        public void UpdatePerformancePieceHire(Piece piece)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdatePerformancePieceHire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@pieceHireID", piece.PieceHireID);
                cmd.Parameters.AddWithValue("@returned", piece.Returned);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Delete piece record
        public void DeletePiece(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeletePiece", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@pieceID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular piece  
        public Piece GetPieceData(int? id)
        {
            Piece piece = new Piece();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Piece WHERE pieceID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    piece.PieceID = Convert.ToInt32(rdr["pieceId"]);
                    piece.Type = rdr["type"].ToString();
                    piece.Part = rdr["part"].ToString();
                    piece.License = rdr["license"].ToString();
                    piece.TotalCopies = Convert.ToInt32(rdr["totalCopies"]);
                    piece.DistributedCopies = Convert.ToInt32(rdr["distributedCopies"]);
                    piece.ReturnedCopies = Convert.ToInt32(rdr["returnedCopies"]);
                }
            }
            return piece;
        }

        //Get the details of a particular piece  hire
        public Piece GetPieceHireData(int? id)
        {
            Piece piece = new Piece();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Piece_Hire WHERE pieceHireID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    piece.PieceHireID = Convert.ToInt32(rdr["pieceHireID"]);
                    piece.Returned = Convert.ToBoolean(rdr["returned"]);
                    //piece.PieceID = Convert.ToInt32(rdr["pieceId"]);
                    //piece.Type = rdr["type"].ToString();
                    //piece.Part = rdr["part"].ToString();
                    //piece.License = rdr["license"].ToString();
                    //piece.TotalCopies = Convert.ToInt32(rdr["totalCopies"]);
                    //piece.DistributedCopies = Convert.ToInt32(rdr["distributedCopies"]);
                    //piece.ReturnedCopies = Convert.ToInt32(rdr["returnedCopies"]);
                }
            }
            return piece;
        }

    }
}
