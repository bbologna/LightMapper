using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightMapper.Core
{
    public interface IMapDefinition
    {
        void SetResolver(MapResolver resolver);
        bool Match<T, U>()
            where T : class
            where U : class;
    }
}
