using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class STActivityTradingPostRewardPreview : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nID;

		public uint m_nPosition;

		public uint[][] m_vecRewards;

		public string m_strNode;

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
