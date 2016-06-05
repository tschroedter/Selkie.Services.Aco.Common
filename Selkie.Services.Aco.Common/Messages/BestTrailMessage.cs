using System.Collections.Generic;
using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class BestTrailMessage
    {
        [UsedImplicitly]
        public double Alpha;

        [UsedImplicitly]
        public double Beta;

        [UsedImplicitly]
        public double Gamma;

        [UsedImplicitly]
        public int Iteration;

        [UsedImplicitly]
        public double Length;

        [NotNull]
        [UsedImplicitly]
        public IEnumerable<int> Trail = new int[0];

        [NotNull]
        [UsedImplicitly]
        public string Type = "Unknown";
    }
}