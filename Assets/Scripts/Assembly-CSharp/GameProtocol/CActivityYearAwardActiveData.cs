using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityYearAwardActiveData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nNeed;

		public CRewardItem[] vecRewards;

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
