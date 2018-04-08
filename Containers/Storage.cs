using Remix.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Remix.Containers
{
    public static class Storage
    {
        public static List<VariableObject> Variables = new List<VariableObject>();
        public static List<ClassObject> Classes = new List<ClassObject>();
        public static List<string> StringLiterals = new List<string>();
        public static List<Tuple<string, Type>> MethodCalls = new List<Tuple<string, Type>>();
    }
}
