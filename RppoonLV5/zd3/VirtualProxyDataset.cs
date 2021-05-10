using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace zd3
{
    class VirtualProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        public VirtualProxyDataset(string filePath)
        {
            this.filePath = filePath;
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            return dataset.GetData();
        }

        ReadOnlyCollection<List<string>> IDataset.GetData()
        {
            return dataset.GetData();
        }
    }
}
