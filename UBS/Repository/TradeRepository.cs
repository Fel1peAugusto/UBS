using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBS.Model;
using UBS.Model.Interface;
using UBS.Repository.Interface;

namespace UBS.Repository
{
    public class TradeRepository : ITradeRepository
    {
        public List<TradeCategories> Categorize(List<ITrade> lista)
        {
            List<TradeCategories> tradeCategories = new();
            foreach (ITrade item in lista)
            {
                TradeCategories tc = new TradeCategories();
                tc.GetCategoria(item.Value, item.ClientSector );
                tradeCategories.Add(tc);
            }
            return tradeCategories;
        }

        public List<TradeCategories> Categorize(List<Trade> lista)
        {
            List<TradeCategories> tradeCategories = new();
            foreach (ITrade item in lista)
            {
                TradeCategories tc = new TradeCategories();
                tc.GetCategoria(item.Value, item.ClientSector);
                tradeCategories.Add(tc);
            }
            return tradeCategories;
        }
    }
}
