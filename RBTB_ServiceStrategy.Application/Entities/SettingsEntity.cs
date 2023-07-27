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
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Value { get; set; }

        [ForeignKey("StrategyEntity")]
        public Guid IdStrategy { get; set; }

        public virtual StrategyEntity StrategyEntity { get; set; }
    }
}
