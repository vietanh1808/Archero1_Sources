using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivity5thAnniRewardData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public uint m_nNeed;

		public uint m_nExtra;

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
