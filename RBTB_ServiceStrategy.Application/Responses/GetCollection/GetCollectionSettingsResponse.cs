using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Responses.GetCollection
{
    public class GetCollectionSettingsResponse : BaseResponse
    {
        public IEnumerable<GetCollectionSettingsId> Settings{ get; set; }
    }

    public class GetCollectionSettingsId
    {
        public Guid IdSettings { get; set; }
    }
}
