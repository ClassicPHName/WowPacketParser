using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientCooldownEvent
    {
        public ulong CasterGUID;
        public int SpellID;
    }
}
