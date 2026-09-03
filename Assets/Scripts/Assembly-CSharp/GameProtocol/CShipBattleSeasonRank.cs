using System.IO;

namespace GameProtocol
{
	public sealed class CShipBattleSeasonRank : CProtocolBase
	{
		public ushort m_nType;

		public ushort m_nCampRankIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
