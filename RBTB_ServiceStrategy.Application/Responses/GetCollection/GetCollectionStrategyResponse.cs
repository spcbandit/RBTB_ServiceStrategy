using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Application.Responses.GetCollection
{
    public class GetCollectionStrategyResponse : BaseResponse
    {
        public IEnumerable<GetCollectionStrategyId> Strategies { get; set; }
    }

    public class GetCollectionStrategyId
    {
        public Guid IdStrategy { get; set; }
    }
}
