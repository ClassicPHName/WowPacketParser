using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct PlayerCliUseEquipmentSet
    {
        public InvUpdate Inv;
        public EquipmentSetItem[/*19*/] Items;
    }
}
