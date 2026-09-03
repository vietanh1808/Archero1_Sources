using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameHarvest2 : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nQuickStartTime;

		public CRewardItem[] m_vecRewardItem;

		public string m_strExtend;

		public ulong m_nQuickBuyTime;

		public ushort m_nDailyCnt;

		public ushort m_nHarvestLevel;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
