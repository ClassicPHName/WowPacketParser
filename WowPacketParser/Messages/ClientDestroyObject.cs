using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientDestroyObject
    {
        public bool IsDead;
        public ulong Guid;
    }
}
