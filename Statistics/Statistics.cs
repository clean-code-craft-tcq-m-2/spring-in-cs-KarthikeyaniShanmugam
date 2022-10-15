using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            Dictionary<string, object> outputDict = new Dictionary<string, object>();

            if (numbers.Count > 0)
            {
                outputDict.Add("avg", numbers.Sum() / numbers.Count);
                outputDict.Add("min", (numbers.Min()));
                outputDict.Add("max", (numbers.Max()));
            }
            else
            {
                outputDict.Add("avg", Double.NaN);
                outputDict.Add("min", Double.NaN);
                outputDict.Add("max", Double.NaN);
            }
            return outputDict;
        }
    }
}
