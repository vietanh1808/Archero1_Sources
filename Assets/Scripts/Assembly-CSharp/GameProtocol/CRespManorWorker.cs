using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespManorWorker : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CManorWorker[] m_arrayWorker;

		public ulong m_ERowId;

		public ushort m_nStar;

		public Dictionary<uint, Dictionary<ushort, ulong>> m_mapBuiding2Workers;

		public Dictionary<uint, ulong> mapBuildResTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
