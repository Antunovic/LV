using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace zd4
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
