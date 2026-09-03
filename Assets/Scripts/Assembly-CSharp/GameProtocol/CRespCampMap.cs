using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampMap : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nSelfBaseCampIndex;

		public Dictionary<uint, STCampSeasonBlock> m_mapBlock;

		public Dictionary<uint, ulong> m_mapMarked;

		public Dictionary<uint, uint> m_mapDispatchHeroId;

		public Dictionary<uint, ulong> m_mapResourceResetTime;

		public Dictionary<uint, bool> m_mapReceivedOnceReward;

		public uint[] m_vecPassedBlockIndex;

		public ushort m_nPassBlockLevel;

		public uint[] m_vecReceivedTreasureBlockIndex;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
