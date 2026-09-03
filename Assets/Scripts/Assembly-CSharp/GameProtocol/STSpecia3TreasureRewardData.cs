using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STSpecia3TreasureRewardData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nID;

		public uint m_nPos;

		public uint[] m_vecReward;

		public uint m_nLuckyValue;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
