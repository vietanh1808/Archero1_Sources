using System.IO;

namespace GameProtocol
{
	public sealed class CActivityRedpacketInfo : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nPageStart;

		public ulong m_nRedpacketId;

		public ushort m_nRedpacketNum;

		public ushort m_nGiftId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
