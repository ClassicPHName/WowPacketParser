using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientStreamingMovies
    {
        public List<ushort> MovieIDs;
    }
}
