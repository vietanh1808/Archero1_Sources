using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityPirateTreasureVault : IProtocol
	{
		public string m_strItemsCfg;

		public uint[] m_vecCostItemsCfg;

		public string m_strOpenGrids;

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
