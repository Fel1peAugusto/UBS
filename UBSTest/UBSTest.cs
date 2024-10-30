using UBS.Model;
using UBS.Model.Interface;
using UBS.Repository;
using UBS.Repository.Interface;
using UBSAPI.Controllers;

namespace UBSTest
{
    public class UBSTest
    {
        [Fact]
        public Task CategorizeTest()
        {
            List<ITrade> portifolio = new();
            
            Trade trade1 = new Trade(2000000, "Private");
            Trade trade2 = new Trade(400000, "Public");
            Trade trade3 = new Trade(500000, "Public");
            Trade trade4 = new Trade(3000000, "Public");
            portifolio.Add(trade1);
            portifolio.Add(trade2);
            portifolio.Add(trade3);
            portifolio.Add(trade4);

            var repository = new TradeRepository();
            var retorno = repository.Categorize(portifolio);
            return Task.CompletedTask;
        }
    }
}