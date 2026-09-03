using System.IO;

namespace GameProtocol
{
	public sealed class CReqOpenRelicsBox : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nDiamond;

		public ushort m_nBatchCount;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
