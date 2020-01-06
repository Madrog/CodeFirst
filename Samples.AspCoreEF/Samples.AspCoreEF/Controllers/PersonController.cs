using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Samples.AspCoreEF.DAL.EF.EntityFrameworkContext;
using Samples.AspCoreEF.DAL.EF.Models;

namespace Samples.AspCoreEF.Controllers
{
    [Route("api/persons")]
    public class PersonController : Controller
    {
        private TaskSystemDbContext _taskContext;

        public PersonController(TaskSystemDbContext taskContext)
        {
            _taskContext = taskContext;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //List<Person> list1 = new List<Person>();
            //foreach (var person in _taskContext.Persons)
            //    list1.Add(person);
            //var list = list1.Select(p => p.Name);
            //return list;

            var list = _taskContext.Persons.ToList().Select(p => p.Name);
            return list;
        }
    }
}
