using System;
using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class FinishedMessage
    {
        [UsedImplicitly]
        public DateTime FinishTime;

        [UsedImplicitly]
        public DateTime StartTime;

        [UsedImplicitly]
        public int Times;
    }
}