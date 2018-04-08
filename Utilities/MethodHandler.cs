using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Remix.Utilities
{
    public static class MethodHandler
    {
        public static void Process()
        {
            foreach (var item in Containers.Storage.MethodCalls)
            {
                Type methodType = item.Item2;
                MethodInfo methods = methodType.GetMethod(item.Item1);
                methods.Invoke(null, new object[] { Containers.Storage.StringLiterals.ToArray() });
            }

            Containers.Storage.StringLiterals.RemoveAll(x => x != null);
            Containers.Storage.MethodCalls.RemoveAll(x => x != null);
        }
    }
}
