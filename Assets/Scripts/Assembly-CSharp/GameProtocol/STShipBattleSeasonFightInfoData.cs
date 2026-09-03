using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonFightInfoData
	{
		public ushort m_nType;

		public ulong nId;

		public STViewRole m_stViewRole;

		public uint m_nPower;

		public Dictionary<uint, STShipBattleSeasonFightComponentData> m_mapShipComponents;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
