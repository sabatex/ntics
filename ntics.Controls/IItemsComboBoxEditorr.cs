using System;
using System.Collections.Generic;
using System.Text;

namespace ntics.Controls
{
    public interface IItemsComboBoxEditor<T>
    {
        public T SelectedItem { get; set; }
    }
}
