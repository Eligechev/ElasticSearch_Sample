using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        private List<string> _sampleList = new List<string>();
        CollegeDbContext dbcontext = new CollegeDbContext();

        public List<string> SampleList {
            get
            {
                return _sampleList;
            } 
        }
        // GET api/values
        public IEnumerable<Models.Model> Get()
        {
            return dbcontext.Set<Models.Model>();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            _sampleList.Add(value);
            dbcontext.Models.Add(new Models.Model
            {
                id = 1,
                SampleString = value
            });
            dbcontext.SaveChanges();

        }
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
