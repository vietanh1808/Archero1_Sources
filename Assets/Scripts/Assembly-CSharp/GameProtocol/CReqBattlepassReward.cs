using System.IO;

namespace GameProtocol
{
	public sealed class CReqBattlepassReward : CProtocolBase
	{
		public uint m_nTransID;

		public uint m_nBattleTag;

		public ushort m_nType;

		public uint m_nKillsOrRewardId;

		public uint m_nRewardIndex;

		public string m_strExtra;

		public string m_strExtend;

		public ushort m_nBattlePassType;

		public ushort m_nBattlePassId;

		public ushort m_nBattlePassIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
