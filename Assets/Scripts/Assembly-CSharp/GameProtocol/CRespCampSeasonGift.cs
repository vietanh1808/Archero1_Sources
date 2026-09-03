using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampSeasonGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strDailyGifts;

		public string m_strWarGifts;

		public string m_strCampGifts;

		public string m_strTimeGifts;

		public string m_strBuyGifts;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
