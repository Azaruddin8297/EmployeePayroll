using DataLayer.Models;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Service
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly IConfiguration configuration;
        readonly SqlConnection connection = new SqlConnection();
        readonly string connectionstring;

        public EmployeeRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionstring = configuration.GetConnectionString("DBConnection");
            connection.ConnectionString = connectionstring;
        }

        public EmployeeModel RegisterEmployee(EmployeeModel employee)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spAddEmployee", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Profile", employee.Profile);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.Parameters.AddWithValue("@StartDate", employee.StartDate);
                cmd.Parameters.AddWithValue("@Notes", employee.Notes);
                cmd.Parameters.AddWithValue("@IsTrash", employee.IsTrash);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdateAt", DateTime.Now);
                cmd.ExecuteNonQuery();
                connection.Close();
                return employee;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            try
            {
                List<EmployeeModel> lstemployee = new List<EmployeeModel>();
                SqlCommand cmd = new SqlCommand("spGetAllEmployees", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EmployeeModel employee = new EmployeeModel();
                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = Convert.ToChar(rdr["Gender"]);
                    employee.Department = rdr["Department"].ToString();
                    employee.Profile = rdr["Profile"].ToString();
                    employee.Salary = Convert.ToInt32(rdr["Salary"]);
                    employee.StartDate = rdr.GetDateTime(6);
                    employee.IsTrash = Convert.ToBoolean(rdr["IsTrash"]);
                    employee.Notes = rdr["Notes"].ToString();
                    employee.CreatedAt = rdr.GetDateTime(9);
                    employee.UpdateAt = rdr.GetDateTime(10);
                    lstemployee.Add(employee);
                }
                connection.Close();
                return lstemployee;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public EmployeeModel UpdateEmplouee(EmployeeModel model)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("spGetAllEmployees", connection)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        connection.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
       // }
    }
}
