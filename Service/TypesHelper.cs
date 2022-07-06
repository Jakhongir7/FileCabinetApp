using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Helpers
{
    public static class TypesHelper
    {
        public static IEnumerable<Type> GetTypes<T>(T type)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes()).Where(t => t.BaseType == typeof(T));
        }
    }
}
