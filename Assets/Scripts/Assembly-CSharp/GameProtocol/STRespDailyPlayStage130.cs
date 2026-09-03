using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespDailyPlayStage130 : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nFreeCnt;

		public uint m_nBuyCnt;

		public uint m_nCostCnt;

		public uint m_nBattleTransID;

		public ushort[] m_vecBuyLifeCost;

		public uint m_nCostLife;

		public Dictionary<uint, uint> m_mapStageOpenTime;

		public string m_strRewardData;

		public string[] m_vecRewardConfig;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
