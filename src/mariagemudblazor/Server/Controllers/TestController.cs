using Microsoft.AspNetCore.Mvc;
using MariageMudblazor.Shared;

namespace MariageMudblazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
       

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Invite> Get()
        {
            List<Invite> invites = new List<Invite>();

            Invite inv1 = new Invite();
            inv1.Prenom = "Toto";
            inv1.Nom = "Tutu";
            
            invites.Add(inv1);

            Invite inv2 = new(){
                Nom = "Titi",
                Prenom = "Tata"
            };

            invites.Add(inv2);

            return invites;
        }
    }
}
