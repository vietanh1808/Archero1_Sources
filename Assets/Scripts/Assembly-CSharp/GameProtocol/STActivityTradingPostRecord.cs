using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STActivityTradingPostRecord : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong m_nTradeTime;

		public ushort m_nTradeType;

		public uint m_nProductId;

		public uint m_nTradeNum;

		public uint m_nPrice;

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
