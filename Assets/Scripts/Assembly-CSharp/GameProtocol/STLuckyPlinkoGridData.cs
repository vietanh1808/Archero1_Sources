using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STLuckyPlinkoGridData : IProtocol
	{
		public ushort m_nGridID;

		public ushort m_nType;

		public uint m_nCurCount;

		public uint m_nMaxCount;

		public uint[] m_vecRewards;

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
