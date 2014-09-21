using System.Collections.Generic;
using System.Web.Http;

namespace OAuthServer.Api.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(new List<Customer>
            {
                new Customer(1, "André", "Baltieri"),
                new Customer(2, "Bruce", "Wayne"),
                new Customer(3, "Tony", "Stark"),
                new Customer(4, "Peter", "Parker")
            });
        }
    }

    public class Customer
    {
        public Customer(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
