using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Responses.Get
{
    public class GetStrategyResponse : BaseResponse
    {
        public string Name { get; set; }

        public string CurrencyPair { get; set; }

        public string StockMarket { get; set; }
    }
}
