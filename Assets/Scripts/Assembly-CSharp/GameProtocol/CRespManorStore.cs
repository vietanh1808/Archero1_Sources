using System.IO;

namespace GameProtocol
{
	public sealed class CRespManorStore : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CManorExchangeData[] m_vecExchangeData;

		public ushort m_nType;

		public ushort m_nId;

		public short m_nCount;

		public ushort m_ntotalCount;

		public uint m_nStoreCoin;

		public ulong m_nEndTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
