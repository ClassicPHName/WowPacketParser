using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientDebugDrawCylinder
    {
        public uint Id;
        public float Height;
        public Vector3 Base;
        public float Lifetime;
        public uint Settings;
        public Vector3 Direction;
        public float Radius;
        public uint Color;
    }
}
