using EnMachineAPI.DAL;
using EnMachineAPI.IDAL;
using EnMachineAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace EnMachineAPI.Controllers
{
    public class JobController : ApiController
    {
        JobRepository jobPersistance = new JobRepository();
        
        [HttpGet]
        [Route("api/GetJobList")]
        public  HttpResponseMessage GetJobDetailList()
        {
            try
            {
                List<JobList> jobLists = new List<JobList>();
                JobList jobList = new JobList();
                jobLists = jobPersistance.GetJobDetailList();

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(jobLists);
                // Create a HttpResponseMessage with JSON content
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }


        }
    }
}