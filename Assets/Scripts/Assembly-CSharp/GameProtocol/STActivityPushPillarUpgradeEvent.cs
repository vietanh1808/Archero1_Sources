using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public class STActivityPushPillarUpgradeEvent
	{
		public ushort m_nTargetCol;

		public ushort m_nTargetRow;

		public ushort m_nMultiplier;

		public ushort m_nSourceCol;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
