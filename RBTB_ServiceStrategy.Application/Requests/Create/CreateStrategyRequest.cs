using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Create
{
    internal class CreateStrategyRequest 
    {
        public string Name { get; set; }

        public string CurrencyPair { get; set; }

        public string StockMarket { get; set; }
    }
}
