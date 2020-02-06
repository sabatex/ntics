using System;
using System.Collections.Generic;
using System.Text;

namespace ntics.Controls
{
    /// <summary>
    /// Reference item define
    /// </summary>
    public interface IReferenceItem
    {
        /// <summary>
        /// Return reference type for current item
        /// </summary>
        /// <returns>ReferenceType for this item</returns>
        Type GetReferenceType();
        Guid GetItemId();
    }
}
