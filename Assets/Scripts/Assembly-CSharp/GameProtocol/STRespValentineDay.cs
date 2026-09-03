using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public class STRespValentineDay : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort[] m_vecRewardStatus;

		public uint m_nOpenGameLevel;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
