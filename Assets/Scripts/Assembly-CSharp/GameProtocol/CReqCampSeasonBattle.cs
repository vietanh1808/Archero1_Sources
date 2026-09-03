using System.IO;

namespace GameProtocol
{
	public sealed class CReqCampSeasonBattle : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nBlockIndex;

		public uint m_nBattleTransID;

		public ushort m_nResultType;

		public uint m_nRound;

		public string m_strMonKill;

		public uint m_nCoinAmount;

		public uint m_nCrystalAmount;

		public uint m_nExp;

		public CEquipmentItem[] arrayEquipItems;

		public uint m_nBloodPoint;

		public uint m_nCampTalentPoint;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
