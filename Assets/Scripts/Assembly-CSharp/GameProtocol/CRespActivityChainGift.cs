using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityChainGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ushort m_nOpenGameLevel;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nTopic;

		public string m_strItems;

		public ushort m_nRewardGotId;

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
