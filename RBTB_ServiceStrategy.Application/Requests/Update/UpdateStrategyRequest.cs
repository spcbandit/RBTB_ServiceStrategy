﻿using MediatR;
using RBTB_ServiceStrategy.Application.Responses.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Update
{
    public class UpdateStrategyRequest : IRequest<UpdateStrategyResponse>
    {
        public Guid IdStrategy { get; set; }

        public string Name { get; set; }

        public string CurrencyPair { get; set; }

        public string StockMarket { get; set; }
    }
}
