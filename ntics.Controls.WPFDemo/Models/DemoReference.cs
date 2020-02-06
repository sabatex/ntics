using ntics.Controls.WPFDemo.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ntics.Controls.WPFDemo.Models
{
    public class DemoReference : IReference<DemoModel>
    {
        public IEnumerable<DemoModel> GetItems()
        {
            yield return new DemoModel() { Value = "Item 1" };
            yield return new DemoModel() { Value = "Item 1" };
            yield return new DemoModel() { Value = "Item 1" };
            yield return new DemoModel() { Value = "Item 1" };
            yield return new DemoModel() { Value = "Item 1" };
        }

        public Type GetSelectedForm()
        {
            return typeof(DemoSelectItem);
        }
    }
}
