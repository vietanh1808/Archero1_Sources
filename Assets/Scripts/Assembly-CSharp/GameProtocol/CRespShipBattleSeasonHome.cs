using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonHome : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nHomeLevel;

		public uint m_nCampSeasonArrow;

		public uint m_nCampSeasonSuperArrow;

		public ulong m_nStartTime;

		public CRewardItem[] m_vecRewardItem;

		public uint m_nBuyArrowCount;

		public ushort m_nExchangeTalentCnt;

		public uint m_nUsingSkinId;

		public uint[] m_arraySkins;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
