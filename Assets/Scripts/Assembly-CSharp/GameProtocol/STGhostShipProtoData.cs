using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STGhostShipProtoData : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nDifficultId;

		public uint m_nExtraAttrId;

		public uint m_nNeedPrivilege;

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
