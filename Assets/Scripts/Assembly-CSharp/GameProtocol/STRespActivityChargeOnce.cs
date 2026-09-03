using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityChargeOnce : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nEndTime;

		public string m_strItems;

		public string strBuyCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
