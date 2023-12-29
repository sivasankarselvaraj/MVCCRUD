using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DataAccesse_Layer
{
   public  class DoctorsRepository:IDoctorsRepository
    {
        public string Connection;
        public DoctorsRepository(IConfiguration Service)
        {
            Connection = Service.GetConnectionString("Dbconnection");
        }

        public void Insert(Doctors add)
        {
            try
            {

                var Send = new SqlConnection(Connection);
                Send.Open();
                var Insert = $"exec InsertProcedure'{add.DoctorsName}','{add.Qualification}',{add.PassoutYear},{add.PhoneNumber},'{add.Addresss}'";
                Send.Execute(Insert);
                Send.Close();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

            }
        }
        public void Update(long No, Doctors replace)
        {
            try
            {
                var Send = new SqlConnection(Connection);
                Send.Open();
                var Update = $"exec UpdateProcedure {No},'{replace.DoctorsName}','{replace.Qualification}',{replace.PassoutYear},{replace.PhoneNumber},'{replace.Addresss}'";
                Send.Execute(Update);
                Send.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public List<Doctors> GetAll()
        {
            try
            {
                var Send = new SqlConnection(Connection);
                Send.Open();
                var Show = $"exec SelectProcedure ";
                var Details = Send.Query<Doctors>(Show);
                Send.Close();
                return Details.ToList();
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public void Delete(long no)
        {
            try
            {
                var Send = new SqlConnection(Connection);
                Send.Open();
                var Delete = $"exec DeleteProcedure {no}";

                var Cut = Send.Query<Doctors>(Delete);
                Send.Close();
            }
            catch (SqlException)
            {
                throw;
            }


        }
        public Doctors GetbyID(long No)
        {

            try
            {
                var Send = new SqlConnection(Connection);
                Send.Open();
                var Show = $"exec GetbyID {No} ";
                var Details = Send.QueryFirstOrDefault<Doctors>(Show);
                Send.Close();
                return Details;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    
    }
}
