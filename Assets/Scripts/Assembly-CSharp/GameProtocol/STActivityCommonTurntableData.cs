using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityCommonTurntableData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public ushort m_nPosition;

		public uint m_nCount;

		public string m_strRewards;

		public uint m_nTurnCount;

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
