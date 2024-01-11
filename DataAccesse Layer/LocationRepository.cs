using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace DataAccesse_Layer
{
   public  class LocationRepository:ILocationRepository
    {
        public string Connection;
        public LocationRepository(IConfiguration Service)
        {
            Connection = Service.GetConnectionString("Dbconnection");
        }
        public IEnumerable<Locations> GetLocation()
        {
            try
            {
                
                var con = new SqlConnection(Connection);
                con.Open();
                var insert = $"select LocationID,LocationName from Location";
                var send = con.Query<Locations>(insert);
                return send;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
