using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Create
{
    internal class CreateSettingsRequest
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public int IdStrategy { get; set; }
    }
}
