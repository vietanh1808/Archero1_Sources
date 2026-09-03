using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityBadgeDepthData : IProtocol
	{
		public uint m_nId;

		public ushort m_nReceived;

		public uint[][] m_vecRewards;

		public ushort m_nPrivilege;

		public uint m_nDepth;

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
