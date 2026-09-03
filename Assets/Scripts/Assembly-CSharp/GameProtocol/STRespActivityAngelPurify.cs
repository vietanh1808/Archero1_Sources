using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityAngelPurify : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public uint m_nOpenGameLevel;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public uint m_nSelectedRewardId;

		public Dictionary<uint, uint> m_mapBigDrawCount;

		public uint m_nEnergyProgress;

		public uint m_nProgressRewardBits;

		public Dictionary<uint, uint> m_mapChapterErosion;

		public STActivityAngelPurifyTask m_stTask;

		public uint m_nDrawCount;

		public uint m_nDrawRewardBits;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public uint m_nDrawBigRewardId;

		public uint m_nDrawMustCount;

		public uint m_nPrivilegeLevel;

		public STActivityAngelPurifyTask m_stPrivilegeTask;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
