using LightMapper.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigthMapper.Core.Tests.Fakes
{
    public class FakePersonMapDefinition : MapDefinition<FakePersonEntity, FakePersonDto>
    {
        public override FakePersonEntity Map(FakePersonDto toMap)
        {
            return new FakePersonEntity()
            {
                Name = toMap.Name,
                LastName = toMap.LastName
            };
        }
    }
}
