using System.IO;

namespace GameProtocol
{
	public class STReqShipBattleTreasureMap : CProtocolBase
	{
		public uint m_nTransID;

		public uint m_nId;

		public ushort m_nType;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
