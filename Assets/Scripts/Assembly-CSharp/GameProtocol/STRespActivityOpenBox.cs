using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityOpenBox : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint[] vecDropItemIds;

		public uint[] vecDelItemIds;

		public ushort[] vecTimeSpent;

		public STActivityOpenBoxTask[] vecTaskData;

		public STOpenBoxExchangeData[] vecExchangeData;

		public uint nExchangeCount;

		public ushort nRewardCount;

		public ushort nNeedCount;

		public ushort nMaxRewardCount;

		public string strBoxRewards;

		public uint nKeyCount;

		public string strOpeningBox;

		public ushort nLayerIndex;

		public ulong m_nRewardBits;

		public uint m_nLastExchangeCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
