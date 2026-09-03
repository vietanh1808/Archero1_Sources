using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespViewRole : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public Dictionary<ulong, STViewRole> m_mapViewRole;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
