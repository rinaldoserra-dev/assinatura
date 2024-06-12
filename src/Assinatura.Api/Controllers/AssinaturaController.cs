using Microsoft.AspNetCore.Mvc;

namespace Assinatura.Api.Controllers
{
    [ApiController]
    [Route("assinatura")]
    public class AssinaturaController : ControllerBase
    {
        private readonly ILogger<AssinaturaController> _logger;
        public AssinaturaController(ILogger<AssinaturaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("list")]
        public IDictionary<int, string> Get()
        {
            IDictionary<int, string> list = new Dictionary<int, string>();
            list.Add(1, "IPhone");
            list.Add(2, "Laptop");
            list.Add(3, "Samsung TV");
            return list;
        }
    }
}
