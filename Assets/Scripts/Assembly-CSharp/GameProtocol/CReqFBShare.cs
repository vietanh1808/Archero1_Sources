using System.IO;

namespace GameProtocol
{
	public sealed class CReqFBShare : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nShareTransID;

		public ushort m_nChapterId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
