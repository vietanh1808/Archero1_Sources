using System.IO;

namespace GameProtocol
{
	public sealed class CReqTowerDefenceBattle : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nLayerId;

		public uint m_nBattleTransID;

		public ushort m_nResultType;

		public uint m_nCoinAmount;

		public uint m_nExp;

		public CEquipmentItem[] arrayEquipItems;

		public ushort m_nRound;

		public string m_strMonKill;

		public uint m_nBloodPoint;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
