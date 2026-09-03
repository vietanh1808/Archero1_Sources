using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityRedpacketDetail : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nSendUserId;

		public uint m_nRedpacketId;

		public Dictionary<ulong, uint> mapReceivers;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
