using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityCommonTurn : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nTaskEndTime;

		public bool m_bIsEnd;

		public bool m_bIsNew;

		public uint m_nOpenGameLevel;

		public string m_strItems;

		public ushort m_nTurnCount;

		public STActivityCommonTurntableData[] m_vecTurntableData;

		public uint m_nDoTurnId;

		public ushort m_nCurrentTurn;

		public ushort m_nMaxTurn;

		public string m_strBoxItems;

		public ushort m_nTotalTurn;

		public ulong m_nRewardBoxBits;

		public string[] m_verRewardItems;

		public uint m_nStyleId;

		public ulong m_nTaskRewardBits;

		public string m_strTasks;

		public string m_strTaskCount;

		public ushort m_nKeyItemCount;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
