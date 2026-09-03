using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityMagicTask : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nId;

		public uint m_nType;

		public ushort m_nPos;

		public uint m_nNeed;

		public uint m_nShowNeed;

		public uint m_nProcess;

		public ushort m_nDone;

		public uint[] vecArgs;

		public string m_strRewards;

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
