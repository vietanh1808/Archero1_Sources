using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public class STActivityLampWishRewardProtoData
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nBigId;

		public uint m_nReceived;

		public uint m_nRewardIndex;

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
