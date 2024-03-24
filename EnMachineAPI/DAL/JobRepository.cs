using EnMachineAPI.IDAL;
using EnMachineAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;
using Dapper;
using System.Web.Http.Results;

namespace EnMachineAPI.DAL
{
    public class JobRepository: IJobPersistance
    {
        public List<JobList> GetJobDetailList()
        {
            string connectionString=  ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                var result = connection.Query<JobList>("usp_GetJobDetailsList", commandType: CommandType.StoredProcedure).ToList();
                return result;
            }

           

        }
    }
}