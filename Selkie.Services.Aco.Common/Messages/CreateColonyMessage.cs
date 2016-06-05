using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class CreateColonyMessage
    {
        [NotNull]
        [UsedImplicitly]
        public int[][] CostMatrix = new int[0][];

        [NotNull]
        [UsedImplicitly]
        public int[] CostPerFeature = new int[0];

        [UsedImplicitly]
        public int FixedStartNode;

        [UsedImplicitly]
        public bool IsFixedStartNode;
    }
}