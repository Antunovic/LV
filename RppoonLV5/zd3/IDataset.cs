using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace zd3
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
