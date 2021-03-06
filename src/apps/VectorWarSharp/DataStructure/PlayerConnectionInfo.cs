﻿using GGPOSharp;
using System;

namespace VectorWar.DataStructure
{
    [Serializable]
    struct PlayerConnectionInfo
    {
        public GGPOPlayerType type;
        public int playerHandle;
        public PlayerConnectState state;
        public int connectProgress;
        public int disconnectTimeout;
        public long disconnectStart;
    }
}
