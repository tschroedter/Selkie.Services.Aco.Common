using System;
using JetBrains.Annotations;

// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class CreateColonyMessage
    {
        public Guid ColonyId = Guid.NewGuid();

        [NotNull]
        public int[][] CostMatrix = new int[0][];

        [NotNull]
        public int[] CostPerFeature = new int[0];

        public int FixedStartNode;

        public bool IsFixedStartNode;
    }
}