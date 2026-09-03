using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityShipRelicsGift : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nGiftId;

		public ushort m_nClaimStatus;

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
