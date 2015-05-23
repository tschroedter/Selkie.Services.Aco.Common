using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    public class CreateColonyMessage
    {
        [NotNull]
        public int[][] CostMatrix = new int[0][];

        [NotNull]
        public int[] CostPerLine = new int[0];
    }
}