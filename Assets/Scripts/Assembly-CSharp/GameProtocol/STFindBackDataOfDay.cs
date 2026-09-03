using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STFindBackDataOfDay : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint[] m_vecId;

		public ushort[] m_vecCount;

		public uint[] m_vecExtra;

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
