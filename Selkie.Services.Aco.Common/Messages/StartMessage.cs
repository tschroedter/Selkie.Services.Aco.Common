﻿using System;
using JetBrains.Annotations;

namespace Selkie.Services.Aco.Common.Messages
{
    [UsedImplicitly]
    public class StartedMessage
    {
        [UsedImplicitly]
        public Guid ColonyId = Guid.Empty;
    }
}