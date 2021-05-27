using SimonExam.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimonExam.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IEnumerable<spAdamQuery_Result> Get(int id)
        {
            List<spAdamQuery_Result> result = null;
            using (var dbContext  = new AdventureWorks2012Entities())
            {
                result = dbContext.spAdamQuery("", "", "", "").ToList();
            }

            return result;
        }

        // GET api/values?firstName=f&lastName=l&emailAddress=e&phoneNumber=1
        public IEnumerable<spAdamQuery_Result> Get(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            List<spAdamQuery_Result> result = null;
            using (var dbContext = new AdventureWorks2012Entities())
            {
                result = dbContext.spAdamQuery( firstName, lastName, emailAddress, phoneNumber).ToList();
            }

            return result;
        }      

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
