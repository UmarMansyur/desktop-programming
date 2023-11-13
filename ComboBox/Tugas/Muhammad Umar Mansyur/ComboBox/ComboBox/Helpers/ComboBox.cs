using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComboBox.Helpers
{
    class ComboBox
    {
        public int Id { get; private set; }
        public string Value { get; private set; }

        public ComboBox(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

    }
}
