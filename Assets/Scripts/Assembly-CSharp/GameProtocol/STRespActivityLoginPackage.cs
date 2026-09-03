using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityLoginPackage : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nAwardEndTime;

		public uint m_nOpenGameLevel;

		public ushort m_nRefreshDay;

		public string m_strItems;

		public uint m_nStyleId;

		public ushort m_nLoginDays;

		public ulong m_nRewardBits;

		public string strBuyCnt;

		public ulong m_nRefreshTime;

		public ushort m_nTag;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
