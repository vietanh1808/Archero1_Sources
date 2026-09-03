using System.IO;

namespace GameProtocol
{
	public sealed class STReqShipBattleSeasonPlayerInfo : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public ulong m_nUserID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
