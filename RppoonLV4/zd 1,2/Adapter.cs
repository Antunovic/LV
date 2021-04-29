using System.Collections.Generic;

namespace zd1
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> dataList = dataset.GetData();

            double[][] dataArray = new double[dataList.Count][];

            for(int i = 0; i < dataList.Count; i++)
            {
                dataArray[i] = new double[dataList[i].Count];
            }

            for(int i = 0; i < dataList.Count; i++)
            {
                for(int j = 0; j < dataList[i].Count; j++)
                {
                    dataArray[i][j] = dataList[i][j];
                }
            }

            return dataArray;


            

        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
