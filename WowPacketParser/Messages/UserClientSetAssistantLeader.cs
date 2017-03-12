using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct UserClientSetAssistantLeader
    {
        public bool Set;
        public byte PartyIndex;
        public ulong Target;
    }
}
