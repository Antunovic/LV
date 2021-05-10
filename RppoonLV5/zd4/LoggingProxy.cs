using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace zd4
{
    class LoggingProxy : IDataset
    {

        private Dataset dataset;
        private ConsoleLogger consoleLogger;

        public LoggingProxy()
        {
            consoleLogger = ConsoleLogger.GetInstance();
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            dataset = new Dataset("sensitiveData.csv");

            consoleLogger.LogTime();

            return this.dataset.GetData();

        }
    }
}
