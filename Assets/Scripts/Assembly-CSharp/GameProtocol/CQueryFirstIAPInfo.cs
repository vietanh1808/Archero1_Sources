using System.IO;

namespace GameProtocol
{
	public sealed class CQueryFirstIAPInfo : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
