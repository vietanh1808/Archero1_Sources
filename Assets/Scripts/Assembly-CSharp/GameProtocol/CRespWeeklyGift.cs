using System.IO;

namespace GameProtocol
{
	public sealed class CRespWeeklyGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nResponseType;

		public ushort m_nTag;

		public ulong m_nResetTimestamp;

		public string m_strRewardInfo;

		public ushort m_nReceivedLog;

		public ushort m_nRewardCount;

		public ushort m_nLoginDays;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
