using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityMonopolyCore : IProtocol
	{
		public ushort m_nRoundIndex;

		public ushort m_nPosition;

		public ushort[] m_vecTileId;

		public ushort m_nNum;

		public ushort m_nRollTimes;

		public ushort m_nNeedRollTimesInTile;

		public ushort m_nDice1;

		public ushort m_nDice2;

		public ushort m_nWheelId;

		public ushort m_nWheelMultiple;

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
