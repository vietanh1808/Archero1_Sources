using System.IO;

namespace GameProtocol
{
	public sealed class CRespLayerIAPInfoNew : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strNormalInfo;

		public string m_strHeroInfo;

		public string m_strHellInfo;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
