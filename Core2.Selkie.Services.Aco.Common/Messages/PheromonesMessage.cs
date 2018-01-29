using System;
using JetBrains.Annotations;

// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class PheromonesMessage
    {
        public double Average;
        public Guid ColonyId = Guid.Empty;
        public double Maximum;
        public double Minimum;

        [NotNull]
        public double[][] Values = new double[0][];
    }
}