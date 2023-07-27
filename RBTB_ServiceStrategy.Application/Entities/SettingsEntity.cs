using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Entities
{
    public class SettingsEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        [ForeignKey("StrategyEntity")]
        public int IdStrategy { get; set; }

        public virtual StrategyEntity StrategyEntity { get; set; }
    }
}
