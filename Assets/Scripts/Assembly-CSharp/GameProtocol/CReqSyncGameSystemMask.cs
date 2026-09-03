using System.IO;

namespace GameProtocol
{
	public sealed class CReqSyncGameSystemMask : CProtocolBase
	{
		public CCommonRespMsg m_syncMsg;

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
