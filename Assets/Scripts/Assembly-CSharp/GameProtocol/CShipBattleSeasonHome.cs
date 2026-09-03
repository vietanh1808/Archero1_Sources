using System.IO;

namespace GameProtocol
{
	public sealed class CShipBattleSeasonHome : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nArrorType;

		public uint m_nArrowNum;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
