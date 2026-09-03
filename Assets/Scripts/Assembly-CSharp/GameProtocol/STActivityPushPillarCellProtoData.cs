using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public class STActivityPushPillarCellProtoData
	{
		public ushort m_nCellType;

		public ushort m_nMultiplier;

		public uint[][] m_vecRewards;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
