using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRespActivitySuperRoulette : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public uint m_nTag;

		public ulong m_nEndTime;

		public ushort m_nNormalFreeCount;

		public ushort m_nNormalCount;

		public uint m_nNormalCost;

		public ushort m_nSuperFreeCount;

		public ushort m_nSuperCount;

		public uint m_nSuperCost;

		public uint m_nTaskLog;

		public CActivitySuperRouletteTask[] m_vecTasks;

		public string m_strNormalTurntable;

		public string m_strSuperTurntable;

		public ushort m_nIsSuper;

		public ushort m_nRandIndex;

		public ushort m_nType;

		public uint m_nTotalCount;

		public uint m_nCountRewardLog;

		public ushort m_nSuperRewardIndex;

		public string m_strSuperRewardConfig;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
