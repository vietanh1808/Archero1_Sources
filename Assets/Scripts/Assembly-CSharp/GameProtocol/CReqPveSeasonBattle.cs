using System.IO;

namespace GameProtocol
{
	public sealed class CReqPveSeasonBattle : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nChapId;

		public ushort m_nStage;

		public uint m_nCoinAmount;

		public uint m_nSoulAmount;

		public uint m_nBattleTransID;

		public string m_strMonKill;

		public string m_strExtend;

		public uint m_nHeroId;

		public uint m_nBloodPoint;

		public ushort m_nBattleType;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
