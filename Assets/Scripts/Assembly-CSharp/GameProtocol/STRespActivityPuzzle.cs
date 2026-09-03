using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityPuzzle : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public string m_strRewards;

		public ulong m_nBoxRewardBits;

		public STActivityPuzzleTask[] vecTaskData;

		public string m_strSpecialItems;

		public ulong m_nSpecialBoxRewardBits;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
