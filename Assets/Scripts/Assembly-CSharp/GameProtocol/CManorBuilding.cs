using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CManorBuilding
	{
		public uint m_nId;

		public ushort m_nLv;

		public ushort m_nStar;

		public Dictionary<ushort, ulong> m_mapWorkerRowId;

		public ulong m_nHarvestTime;

		public Dictionary<ushort, ushort> m_mapAvailableTimes;

		public Dictionary<ushort, ulong> m_mapAvailableRecoverTime;

		public Dictionary<ulong, uint> m_mapStealedRecord;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
