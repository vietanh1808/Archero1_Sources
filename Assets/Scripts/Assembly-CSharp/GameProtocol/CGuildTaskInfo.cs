using System.IO;

namespace GameProtocol
{
	public sealed class CGuildTaskInfo : CProtocolBase
	{
		public ushort m_nType;

		public ushort m_nIdx;

		public uint m_nTransID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
