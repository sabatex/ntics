using System;
using System.Collections.Generic;
using System.Text;

namespace ntics.Controls.WPFDemo.Models
{
    /// <summary>
    /// Demonstrate entity 
    /// </summary>
    public class DemoModel
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public DemoModel()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
