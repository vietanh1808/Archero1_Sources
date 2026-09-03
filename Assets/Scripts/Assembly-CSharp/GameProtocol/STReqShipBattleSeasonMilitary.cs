using System.IO;

namespace GameProtocol
{
	public sealed class STReqShipBattleSeasonMilitary : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nId;

		public override ushort GetMsgType => 0;

		public static STReqShipBattleSeasonMilitary Create(ushort type)
		{
			return null;
		}

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
