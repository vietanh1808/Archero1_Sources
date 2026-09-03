using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonWheel : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public string strRewardConfJson;

		public CWheelData[] m_vecWheelData;

		public ushort m_nRewardId;

		public ushort m_nMultiple;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public bool m_bReceivedDailyReward;

		public ulong m_nRefreshTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
