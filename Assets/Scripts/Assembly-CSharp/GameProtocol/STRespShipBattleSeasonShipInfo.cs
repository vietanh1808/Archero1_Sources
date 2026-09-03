using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespShipBattleSeasonShipInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint[] m_vecShipSkins;

		public STShipBattleShipInfoProtoData m_stShipProtoData;

		public ushort m_nTag;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
