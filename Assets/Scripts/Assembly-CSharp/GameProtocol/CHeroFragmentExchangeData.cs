using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CHeroFragmentExchangeData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nHeroId;

		public ushort m_nCount;

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
