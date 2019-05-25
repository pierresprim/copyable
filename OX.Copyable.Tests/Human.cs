using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OX.Copyable.Tests
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Human
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public List<Human> Children { get; set; }
    }
}
