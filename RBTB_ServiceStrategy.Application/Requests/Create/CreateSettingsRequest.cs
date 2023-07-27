using MediatR;
using RBTB_ServiceStrategy.Application.Responses.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Requests.Create
{
    public class CreateSettingsRequest : IRequest<CreateSettingsResponse>
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public int IdStrategy { get; set; }
    }
}
