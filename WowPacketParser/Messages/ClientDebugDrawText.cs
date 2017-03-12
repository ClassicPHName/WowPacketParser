using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientDebugDrawText
    {
        public byte Alignment;
        public uint Id;
        public uint Color;
        public uint Settings;
        public float Lifetime;
        public float Height;
        public Vector2 Location;
        public string Text;
    }
}
