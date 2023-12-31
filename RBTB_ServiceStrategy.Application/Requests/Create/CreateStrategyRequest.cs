﻿using MediatR;
using RBTB_ServiceStrategy.Application.Responses.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Create
{
    public class CreateStrategyRequest : IRequest<CreateStrategyResponse>
    {
        public string Name { get; set; }

        public string CurrencyPair { get; set; }

        public string StockMarket { get; set; }
    }
}
