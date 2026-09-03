using System.IO;

namespace GameProtocol
{
	public sealed class CRespHeroFragmentExchange : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nType;

		public ushort m_nCount;

		public CHeroFragmentExchangeData[] m_vecExchangeData;

		public uint m_nHeroId;

		public ushort m_nHeroExchangeCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
