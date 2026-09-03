using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STActivityTradingPostGoods : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nProductId;

		public uint m_nTotalAsset;

		public int m_nTotalProfit;

		public uint[] m_vecCurPrice;

		public uint[] m_vecHistoryPrice;

		public int m_netBuying;

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
