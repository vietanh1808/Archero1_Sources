using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityYearAward : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ulong m_nEndTime;

		public ushort m_nTags;

		public CTActivityYearAwardData[] m_vecData;

		public ushort m_nTag;

		public ushort m_nRewardType;

		public uint m_nRewardLog;

		public ulong m_nStartTime;

		public CTActivityYearBossData cTActivityYearBossData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
