using System.IO;

namespace GameProtocol
{
	public sealed class CRespWing : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CWing[] m_arrayWing;

		public ulong m_nRowID;

		public ushort m_nLevel;

		public ushort m_nStarId;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
