﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using Microsoft.Bot.Builder.Dialogs;

namespace Microsoft.Bot.Builder.TestBot
{
    public class TestBotAccessors
    {
        public IStatePropertyAccessor<DialogState> ConversationDialogState { get; set; }

        public SemaphoreSlim SemaphoreSlim { get; } = new SemaphoreSlim(1, 1);
    }
}
