using System;
using JetBrains.Annotations;

// ReSharper disable UnusedMember.Global

namespace Core2.Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class FinishedMessage
    {
        public Guid ColonyId = Guid.Empty;
        public DateTime FinishTime;
        public DateTime StartTime;
        public int Times;
    }
}