using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class PheromonesMessage
    {
        [UsedImplicitly]
        public double Average;

        [UsedImplicitly]
        public double Maximum;

        [UsedImplicitly]
        public double Minimum;

        [NotNull]
        [UsedImplicitly]
        public double[][] Values = new double[0][];
    }
}