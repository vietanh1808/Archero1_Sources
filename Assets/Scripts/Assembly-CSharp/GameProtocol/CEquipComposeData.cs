using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CEquipComposeData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ulong[] m_vecEquipRowIds;

		public uint[] m_vecMatIds;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
