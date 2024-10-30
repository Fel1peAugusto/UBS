using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBS.Model
{
    public class TradeCategories
    {
        public string Categories { get; set; }

        public void GetCategoria(double value, string ClientSector )
        {
            if (ClientSector .ToLower() == "private")
                this.Categories = CategoriesEnum.HIGHRISK.ToString();

            else if (ClientSector .ToLower() == "public" && value > 1000000)
                this.Categories = CategoriesEnum.MEDIUMRISK.ToString();
            else
                this.Categories = CategoriesEnum.LOWRISK.ToString();
        }
    }
}
