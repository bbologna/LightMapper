using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightMapper.Core
{
    public class MapResolver
    {
        private List<IMapDefinition> maps;

        public MapResolver()
        {
            maps = new List<IMapDefinition>();
        }

        public void RegisterMap(IMapDefinition mapDefinition)
        {
            maps.Add(mapDefinition);
            mapDefinition.SetResolver(this);
        }

        public returnObject Map<returnObject, toMapObject>(toMapObject obj)
            where returnObject : class
            where toMapObject : class
        {
            var map = maps.Single(x => x.Match<returnObject, toMapObject>());
            var typedMap = map as MapDefinition<returnObject, toMapObject>;
            return typedMap.Map(obj);
        }
    }
}
