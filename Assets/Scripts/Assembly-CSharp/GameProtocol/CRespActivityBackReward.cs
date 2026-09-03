using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityBackReward : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strItems;

		public ulong m_nRewardTime;

		public ulong m_nEndTime;

		public ulong m_nRewardBits;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
