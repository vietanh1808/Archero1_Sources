using System.IO;

namespace GameProtocol
{
	public sealed class STReqDailyPlayStage130 : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nStageID;

		public uint m_nBattleTransID;

		public ulong m_nDamage;

		public uint m_nHeroID;

		public CEquipmentItem[] arrayEquipItems;

		public uint m_nCoinAmount;

		public uint m_nExperince;

		public uint m_nRebornType;

		public uint m_nRebornCount;

		public uint m_nId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
