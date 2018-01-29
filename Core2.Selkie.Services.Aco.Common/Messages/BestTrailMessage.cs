using System;
using System.Collections.Generic;
using JetBrains.Annotations;

// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class BestTrailMessage
    {
        public double Alpha;
        public double Beta;
        public Guid ColonyId = Guid.Empty;
        public double Gamma;
        public int Iteration;
        public double Length;

        [NotNull]
        public IEnumerable <int> Trail = new int[0];

        [NotNull]
        public string Type = "Unknown";
    }
}