using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STRespActivityBadge : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public STCommonTaskData[] m_vecTaskData;

		public STActivityBadgeDepthData[] m_vecDepthData;

		public uint m_nDepthCount;

		public ushort m_nWishOpen;

		public ushort m_nUpGroup;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
