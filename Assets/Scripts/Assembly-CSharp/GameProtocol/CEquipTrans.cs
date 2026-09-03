using System.IO;

namespace GameProtocol
{
	public sealed class CEquipTrans : CProtocolBase
	{
		public enum eEquipTransType
		{
			ETransBuyType = 1,
			ETransSellType = 2,
			EBlackAdShop = 3,
			EBuyCharacter = 4,
			EExchangeCharacter = 5,
			ETransInvalidType = 6
		}

		public uint m_nTransID;

		public CEquipmentItem m_stEquipItem;

		public uint m_nCoins;

		public uint m_nDiamonds;

		public byte m_nType;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
