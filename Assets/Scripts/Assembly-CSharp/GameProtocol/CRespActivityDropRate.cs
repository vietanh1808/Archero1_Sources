using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityDropRate : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public CActivityDropRateType[] m_vecActivityDropRate;

		public uint m_nRewardLog;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
