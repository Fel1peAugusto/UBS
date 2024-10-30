using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using UBS.Model;
using UBS.Model.Interface;
using UBS.Repository.Interface;

namespace UBSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UBSController 
    {  
        private readonly ITradeRepository _tradeRepository;

        public UBSController(ITradeRepository tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }

        //User Validations
        [SwaggerOperation(Description = "Categorizar as negociações conforme parametros de entrada", Summary = "TradeCategorize")]
        [HttpPost("TradeCategorize")]
        public List<string> TradeCategorize(List<ITrade> portifolio)
        {
            return _tradeRepository.Categorize(portifolio).Select(c => c.Categories).ToList();
        }


        [SwaggerOperation(Description = "Categorizar as negociações conforme parametros de entrada via JSON", Summary = "TradeCategorizeJson")]
        [HttpPost("TradeCategorizeJson")]
        public List<string> CategorizeJson(string portifolio)
        {
            var lista = JsonConvert.DeserializeObject<List<Trade>>(portifolio);
            return _tradeRepository.Categorize(lista).Select(c=> c.Categories).ToList();
        }
    }
}
