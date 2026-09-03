using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRespUserGetInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strNickName;

		public uint m_nHeadIcon;

		public uint m_nHeadFrame;

		public ulong m_nHeadFrameTimestamp;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public uint m_nScore;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
