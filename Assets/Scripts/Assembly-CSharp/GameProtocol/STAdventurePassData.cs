using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STAdventurePassData : IProtocol
	{
		public uint difficulty;

		public uint maxDifficulty;

		public uint[] receivedList;

		public string rewardJson;

		public uint m_nTag;

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
