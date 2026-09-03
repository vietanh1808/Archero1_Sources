using System.IO;

namespace GameProtocol
{
	public sealed class CFarmEvent : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nUniqueId;

		public ushort m_nEventType;

		public ushort m_nPriceType;

		public uint m_nPriceValue;

		public ushort m_nGetRewardType;

		public string extraInfo;

		public ulong m_nTimestamp;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
