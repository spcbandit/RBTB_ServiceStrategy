using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Entities
{
    public class StrategyEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CurrencyPair { get; set; }

        public string StockMarket { get; set; }

        public virtual List<SettingsEntity> SettingsEntities { get; set; } = new();
    }
}
