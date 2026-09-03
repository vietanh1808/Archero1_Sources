using System.IO;

namespace GameProtocol
{
	public sealed class CReqResourceFindBack : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nDay;

		public uint m_nBackId;

		public ushort m_nBackType;

		public ushort m_nBackCount;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
