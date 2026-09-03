using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityFrozenFortress : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public uint m_nOpenGameLevel;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nCurDifficulty;

		public uint m_nMaxDifficulty;

		public uint m_nScore;

		public uint m_nBoxRewardBits;

		public uint m_nExtraBoxCount;

		public STFrozenFortressBoxRewardProtoData[] m_vecBoxRewardData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
