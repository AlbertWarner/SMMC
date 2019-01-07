using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SMMC.Models
{
    public class InstrumentDataAccessLayer
    {
        //string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";

        //To View all instruments details    
        public IEnumerable<Instrument> GetAllInstruments()
        {
            List<Instrument> lstinstrument = new List<Instrument>();

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
                    Instrument instrument = new Instrument
                    {
                        ID = Convert.ToInt32(rdr["instrumentID"]),
                        Name = rdr["instrumentName"].ToString()
                    };

                    lstinstrument.Add(instrument);
                }
                con.Close();
            }
            return lstinstrument;
        }


        //To View all instruments hire for student details    
        public IEnumerable<Instrument> GetStudentInstrumentHire()
        {
            List<Instrument> lstinstrumenthire = new List<Instrument>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetstudenthire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Instrument instrument = new Instrument
                    {
                        ID = Convert.ToInt32(rdr["HireID"]),
                        Firstname = rdr["Firstname"].ToString(),
                        Surname = rdr["Surname"].ToString(),
                        Name = rdr["InstrumentName"].ToString(),
                        HireDate = Convert.ToDateTime(rdr["HireDate"]),
                        Fee = Convert.ToDouble(rdr["Fee"]),
                        Repair = Convert.ToBoolean(rdr["Repair"]),
                        Returned = Convert.ToBoolean(rdr["Returned"])
                    };

                    lstinstrumenthire.Add(instrument);
                }
                con.Close();
            }
            return lstinstrumenthire;
        }

        //To View all enrolments   
        public IEnumerable<Instrument> GetEnrolment()
        {
            List<Instrument> lstenrolment = new List<Instrument>();

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
                    Instrument enrolment = new Instrument
                    {
                        ID = Convert.ToInt32(rdr["EnrolmentID"]),
                        Firstname = rdr["Firstname"].ToString(),
                        Surname = rdr["Surname"].ToString()
                    };

                    lstenrolment.Add(enrolment);
                }
                con.Close();
            }
            return lstenrolment;
        }

        //To Add new instrument record    
        public void AddInstrument(Instrument instrument)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddInstrument", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@instrumentName", instrument.Name);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Add new instrument hire record    
        public void AddInstrumentHire(Instrument instrument)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddInstrumentHire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@instrumentID", instrument.InstrumentID);
                cmd.Parameters.AddWithValue("@costID", instrument.CostID);
                cmd.Parameters.AddWithValue("@enrolmentID", instrument.EnrolmentID);
                cmd.Parameters.AddWithValue("@repair", instrument.Repair);
                cmd.Parameters.AddWithValue("@returned", instrument.Returned);
                cmd.Parameters.AddWithValue("@hireDate", instrument.HireDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //To Update the records of a particluar instrument  
        public void UpdateInstrument(Instrument instrument)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateInstrument", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@InstrumentId", instrument.ID);
                cmd.Parameters.AddWithValue("@InstrumentName", instrument.Name);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particluar instrument hire 
        public void UpdateInstrumentHire(Instrument instrument)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateInstrumentHire", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@hireID", instrument.ID);
                cmd.Parameters.AddWithValue("@repair", instrument.Repair);
                cmd.Parameters.AddWithValue("@returned", instrument.Returned);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Delete the record on a particular instrument  
        public void DeleteInstrument(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteInstrument", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@InstrumentId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular instrument  
        public Instrument GetInstrumentData(int? id)
        {
            Instrument instrument = new Instrument();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Instrument WHERE instrumentId= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    instrument.ID = Convert.ToInt32(rdr["instrumentId"]);
                    instrument.Name = rdr["instrumentName"].ToString();
                }
            }
            return instrument;
        }

        //Get the details of a particular instrument hire record 
        public Instrument GetInstrumentHireData(int? id)
        {
            Instrument instrumentHire = new Instrument();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT  Hire.hireID as [HireID], " +
                    "Person.firstname as [Firstname] , " +
                    "Person.surname as [Surname], " +
                    "Instrument.instrumentName as [InstrumentName]," +
                    " Cost.hireFee as [Fee], " +
                    "Hire.repair as [Repair], " +
                    "Hire.returned as [Returned], " +
                    "Hire.hireDate as [HireDate] " +
                    "FROM Enrolment JOIN Person  ON Person.personID = Enrolment.personID " +
                    "JOIN Hire on Hire.enrolmentID = Enrolment.enrolmentID " +
                    "JOIN Cost ON Hire.costID = Cost.costID " +
                    "JOIN Instrument ON Hire.instrumentID = Instrument.instrumentID " +
                    "WHERE hireID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    instrumentHire.ID = Convert.ToInt32(rdr["HireID"]);
                    instrumentHire.Firstname = rdr["Firstname"].ToString();
                    instrumentHire.Surname = rdr["Surname"].ToString();
                    instrumentHire.Name = rdr["InstrumentName"].ToString();
                    instrumentHire.HireDate = Convert.ToDateTime(rdr["HireDate"]);
                    instrumentHire.Fee = Convert.ToDouble(rdr["Fee"]);
                    instrumentHire.Repair = Convert.ToBoolean(rdr["Repair"]);
                    instrumentHire.Returned = Convert.ToBoolean(rdr["Returned"]);
                }
            }
            return instrumentHire;
        }
    }
}
