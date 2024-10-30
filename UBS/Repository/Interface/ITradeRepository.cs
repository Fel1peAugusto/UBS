using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBS.Model.Interface;
using UBS.Model;

namespace UBS.Repository.Interface
{
    public interface ITradeRepository
    {
        List<TradeCategories> Categorize(List<ITrade> lista);
        List<TradeCategories> Categorize(List<Trade> lista);
    }
}
