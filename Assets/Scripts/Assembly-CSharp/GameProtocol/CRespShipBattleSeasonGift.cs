using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public Dictionary<uint, STShipBattleSeasonGift> m_mapGifts;

		public Dictionary<uint, STShipBattleSeasonGift> m_mapLimitGifts;

		public Dictionary<uint, STShipBattleSeasonGift> m_mapEventsGifts;

		public STShipBattleSeasonGiftConf[] m_vecGiftsConf;

		public STShipBattleSeasonGiftConf[] m_vecLimitGiftsConf;

		public STShipBattleSeasonGiftConf[] m_vecEventsGiftsConf;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
