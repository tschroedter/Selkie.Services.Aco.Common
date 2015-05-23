using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    public class PheromonesMessage
    {
        public double Average;
        public double Maximum;
        public double Minimum;

        [NotNull]
        public double[][] Values = new double[0][];
    }
}