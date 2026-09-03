using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CDragonComposeData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong[] m_vecEquipRowIds;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
