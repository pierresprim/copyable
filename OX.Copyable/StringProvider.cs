using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OX.Copyable
{
    public class StringProvider : InstanceProvider<string>
    {
        public override string CreateTypedCopy(string toBeCopied) => string.Copy(toBeCopied);
    }
}
