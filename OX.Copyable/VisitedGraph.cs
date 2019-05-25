using System.Collections.Generic;

namespace OX.Copyable
{
    class VisitedGraph : Dictionary<object, object>
    {
        public new bool ContainsKey(object key) => key == null ? true : base.ContainsKey(key);

        public new object this[object key] => key == null ? null : base[key];
    }
}
