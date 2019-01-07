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
    public class StudentDataAccessLayer 
    {
        //string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_olusoe1;User Id=olusoe1;Password=************;";
        string connectionString = "Server=FTHICTSQL04.ict.op.ac.nz;Database=IN705_201802_warnaa1;User Id=warnaa1;Password=************;";

        //To View all Student details    
        public IEnumerable<Student> GetAllStudents()
        {
            List<Student> listStudent = new List<Student>();

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
                    Student student = new Student
                    {
                        personID = Convert.ToInt32(reader["personID"]),
                        Firstname = reader["FirstName"].ToString(),
                        Surname = reader["Surname"].ToString(),
                        skill = reader["skill"].ToString(),
                        role = reader["role"].ToString(),
                        schoolName = reader["school Name"].ToString(),
                        enrolled = Convert.ToBoolean(reader["enrolled"]),
                        instrumentName = reader["Instrument"].ToString()
                    };

                    listStudent.Add(student);
                }
                con.Close();
            }
            return listStudent;
        }

        //To View all Parent and Student details    
        public IEnumerable<Student> GetParentStudents()
        {
            List<Student> listStudent = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetParentStudent", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student
                    {
                      
                        personID = Convert.ToInt32(reader["parentID"]),
                        Firstname = reader["Child Name"].ToString(),
                        Surname = reader["Child Surname"].ToString(),
                        ParentName = reader["Parent Name"].ToString(),
                        ParentSurname = reader["Parent Surname"].ToString(),
                        phone = Convert.ToInt32(reader["Phone"]),
                        emailAddress = reader["Email"].ToString()

                    };

                    listStudent.Add(student);
                }
                con.Close();
            }
            return listStudent;
        }

        //To View all Contact details    
        public IEnumerable<Student> GetContact()
        {
            List<Student> listStudent = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetContact", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student
                    {

                        personID = Convert.ToInt32(reader["personID"]),
                        Firstname = reader["firstname"].ToString(),
                        Surname = reader["surname"].ToString(),
                        phone = Convert.ToInt32(reader["phone"]),
                        emailAddress = reader["email"].ToString()

                    };

                    listStudent.Add(student);
                }
                con.Close();
            }
            return listStudent;
        }




        //Get the details of a particular Student  
        public Student GetStudentData(int? personID)
        {
            Student student = new Student();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Person WHERE personID =" + personID;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    student.personID = Convert.ToInt32(reader["personID"]);
                    student.Firstname = reader["FirstName"].ToString();
                    student.Surname = reader["Surname"].ToString();
                    student.skill = reader["skill"].ToString();
                    student.role = reader["role"].ToString();          
                }
            }
            return student;
        }


        //Get the details Contact of a particular Student  
        public Student GetContactData(int? personID)
        {
            Student student = new Student();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Contact WHERE personID =" + personID;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    student.personID = Convert.ToInt32(reader["personID"]);
                    student.phone = Convert.ToInt32(reader["phone"]);
                    student.emailAddress = reader["emailAddress"].ToString();
                }
            }
            return student;
        }


        //Get the details School of a particular Student  
        public Student GetSchoolData(int? personID)
        {
            Student student = new Student();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM School_Enrolment WHERE personID =" + personID;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    student.personID = Convert.ToInt32(reader["personID"]);
                    student.enrolled = Convert.ToBoolean(reader["enrolled"]);
                    student.schoolName = reader["schoolName"].ToString();
                }
            }
            return student;
        }

        //Add student to person
        public int AddStudent(Student student)
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddPerson", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@firstname", student.Firstname);
                cmd.Parameters.AddWithValue("@surname", student.Surname);
                cmd.Parameters.AddWithValue("@skill", student.skill);
                cmd.Parameters.AddWithValue("@role", student.role);
                cmd.Parameters.AddWithValue("@salary", 0.00);


                con.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            return id;
        }

        //Add Parent to person
        public int AddParent(Student student)
        {
            int id = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddParent", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@firstname", student.ParentName);
                cmd.Parameters.AddWithValue("@surname", student.ParentSurname);            
                cmd.Parameters.AddWithValue("@role", student.ParentRole);

                con.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar()); //This allows to get the user id to store in variable
                con.Close();
            }
            return id;
        }

        //Add school to that person
        public void AddStudentSchool(Student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddSchool_Enrolment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", student.personID);
                cmd.Parameters.AddWithValue("@parentID", student.parentID);
                cmd.Parameters.AddWithValue("@schoolName", student.schoolName);
                cmd.Parameters.AddWithValue("@enrolled", student.enrolled);
                cmd.Parameters.AddWithValue("@costID", student.costID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Add new person contact    
        public void AddContact(Student student, int? personID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddContact", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", personID);
                cmd.Parameters.AddWithValue("@phone", student.phone);
                cmd.Parameters.AddWithValue("@emailAddress", student.emailAddress);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Add new person contact    
        public void AddSchoolEnrolment(Student student, int? personID, int? parentID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddSchool_Enrolment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", personID);
                cmd.Parameters.AddWithValue("@parentID", parentID);
                cmd.Parameters.AddWithValue("@schoolName", student.schoolName);
                cmd.Parameters.AddWithValue("@enrolled", student.enrolled);
                cmd.Parameters.AddWithValue("@costID", student.costID);
                cmd.Parameters.AddWithValue("@costOpenID", student.costOpenID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        //To View all cost for students    
        public IEnumerable<Student> GetStudentCost()
        {
            List<Student> listStudentCost = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetStudentCost", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Student costStudent = new Student();
                    costStudent.costID = Convert.ToInt32(rdr["costID"]);
                    costStudent.instrumentName = rdr["Instrument Name"].ToString();
                    costStudent.studentFee = Convert.ToDecimal(rdr["Student Fee"]);

                          
                    listStudentCost.Add(costStudent);
                }
                con.Close();
            }
            return listStudentCost;
        }

        //To View all cost for Open    
        public IEnumerable<Student> GetOpenCost()
        {
            List<Student> listOpenCost = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetOpenCost", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Student costOpen = new Student();
                    costOpen.costOpenID = Convert.ToInt32(rdr["CostOpenID"]);
                    costOpen.instrumentName = rdr["Instrument Name"].ToString();
                    costOpen.studentFee = Convert.ToDecimal(rdr["Open Fee"]);


                    listOpenCost.Add(costOpen);
                }
                con.Close();
            }
            return listOpenCost;
        }


        //To Delete the record on a particular Student  
        public void DeleteStudent(int? personID)
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

        //Update student to person
        public void UpdateStudent(Student student)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", student.personID);
                cmd.Parameters.AddWithValue("@firstname", student.Firstname);
                cmd.Parameters.AddWithValue("@surname", student.Surname);
                cmd.Parameters.AddWithValue("@skill", student.skill);
                cmd.Parameters.AddWithValue("@role", student.role);


                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }

        //Update student to person
        public void UpdateParent(Student student)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateParent", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", student.personID);
                cmd.Parameters.AddWithValue("@firstname", student.Firstname);
                cmd.Parameters.AddWithValue("@surname", student.Surname);
                cmd.Parameters.AddWithValue("@role", student.role);


                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }

        //Update Contact
        public void UpdateContact(Student student)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateContact", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", student.personID);
                cmd.Parameters.AddWithValue("@phone", student.phone);
                cmd.Parameters.AddWithValue("@emailAddress", student.emailAddress);

                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }

        //Update School
        public void UpdateSchool(Student student)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateSchool", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@personID", student.personID);
                cmd.Parameters.AddWithValue("@enrolled", student.enrolled);
                cmd.Parameters.AddWithValue("@schoolName", student.schoolName);

                con.Open();
                cmd.ExecuteScalar();
                con.Close();
            }
        }



    }
}
