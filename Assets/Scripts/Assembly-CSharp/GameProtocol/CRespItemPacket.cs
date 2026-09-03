using System.IO;

namespace GameProtocol
{
	public sealed class CRespItemPacket : IProtocol
	{
		public const ushort MsgType = 7;

		public CCommonRespMsg m_commMsg;

		public CEquipmentItem[] m_arrayEquipItems;

		public ushort m_nPacketType;

		public CDropItem[] m_nDropItems;

		public ushort m_nLargeDiamondItemCount;

		public CMonsterEgg[] m_arrayEgg;

		public ushort m_nLargeItemCountActivity;

		public STRelicsItem[] m_arrayRelicsItems;

		public ushort m_nOfflineBattleCount;

		public CTotem[] m_arrayTotemItems;

		public CEquipmentItem[] m_arrayServerEquipItems;

		public CColorfulWeaponSkin[] m_vecSkinData;

		public ushort GetMsgType => 0;

		public bool IsSuccess => false;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
