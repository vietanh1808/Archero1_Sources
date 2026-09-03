using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CActivityLuckyWheelTask : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort m_nId;

		public ushort m_nTaskType;

		public uint m_nNeedValue;

		public uint m_nProcess;

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
