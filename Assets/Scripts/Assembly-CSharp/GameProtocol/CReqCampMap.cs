using System.IO;

namespace GameProtocol
{
	public sealed class CReqCampMap : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nStartBlockIndex;

		public uint m_nEndBlockIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
