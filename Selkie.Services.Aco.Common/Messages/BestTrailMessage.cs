using System.Collections.Generic;
using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    public class BestTrailMessage
    {
        public double Alpha;
        public double Beta;
        public double Gamma;
        public int Iteration;
        public double Length;

        [NotNull]
        public IEnumerable <int> Trail = new int[0];

        [NotNull]
        public string Type = "Unknown";
    }
}