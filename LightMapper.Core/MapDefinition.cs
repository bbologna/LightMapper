using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightMapper.Core
{
    public abstract class MapDefinition<returnType, toMapType> : IMapDefinition
        where returnType : class
        where toMapType : class
    {
        private Type aType;
        private Type bType;
        protected MapResolver resolver;

        public MapDefinition()
        {
            this.aType = typeof(returnType);
            this.bType = typeof(toMapType);
        }

        public void SetResolver(MapResolver resolver)
        {
            this.resolver = resolver;
        }

        public abstract returnType Map(toMapType toMap);

        public bool Match<T, U>()
            where T : class
            where U : class
        {
            var tType = typeof(T);
            var uType = typeof(U);
            return aType.Equals(tType) && bType.Equals(uType);
        }
    }
}
