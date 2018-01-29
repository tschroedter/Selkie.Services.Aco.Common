using System;
using JetBrains.Annotations;

namespace Core2.Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class PheromonesRequestMessage
    {
        [UsedImplicitly]
        public Guid ColonyId = Guid.Empty;
    }
}