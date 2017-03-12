using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientTradeStatus
    {
        public TradeStatus Status;
        public byte TradeSlot;
        public ulong Partner;
        public int CurrencyType;
        public int CurrencyQuantity;
        public bool FailureForYou;
        public int BagResult;
        public int ItemID;
        public uint ID;
        public bool PartnerIsSameBnetAccount;
    }
}
