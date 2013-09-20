using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OX.Copyable
{
    public class StringProvider : InstanceProvider<String>
    {
        public override string CreateTypedCopy(string toBeCopied)
        {
            return String.Copy(toBeCopied);
        }
    }
}
