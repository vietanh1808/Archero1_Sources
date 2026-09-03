using System.IO;

namespace GameProtocol
{
	public sealed class CRespDailyIapGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public bool m_bExistHero;

		public bool m_bExistGem;

		public CDailyGiftHeroData dailyGiftHeroData;

		public CDailyGiftGemData dailyGiftGemData;

		public short m_nSelectHeroIndex;

		public ulong m_nEndTimestamp;

		public ulong m_nBeginTimestamp;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
