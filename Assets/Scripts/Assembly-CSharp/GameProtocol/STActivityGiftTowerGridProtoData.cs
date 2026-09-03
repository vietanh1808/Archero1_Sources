using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public class STActivityGiftTowerGridProtoData
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nGridIndex;

		public uint m_nQuality;

		public uint[][] m_vecRewards;

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
