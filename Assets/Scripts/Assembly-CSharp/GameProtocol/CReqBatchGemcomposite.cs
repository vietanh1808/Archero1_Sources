using System.IO;

namespace GameProtocol
{
	public sealed class CReqBatchGemcomposite : CProtocolBase
	{
		public uint m_nTransID;

		public uint[] m_vecGemID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
