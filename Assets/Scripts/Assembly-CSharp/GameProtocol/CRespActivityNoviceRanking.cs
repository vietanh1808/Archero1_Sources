using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityNoviceRanking : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nEndTime;

		public string m_strTasks;

		public CNoviceReward[] m_vecPointRewards;

		public CNoviceReward[] m_vecRankRewards;

		public uint m_nTotalPoint;

		public uint[] m_arrayPointRewardDone;

		public CNoviceRank[] m_vecRank;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
