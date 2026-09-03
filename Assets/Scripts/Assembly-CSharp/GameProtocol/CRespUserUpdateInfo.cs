using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRespUserUpdateInfo : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strNickName;

		public uint m_nHeadId;

		public uint m_nHeadFrameId;

		public ulong m_nHeadFrameTimestamp;

		public uint m_nRenameDiamonds;

		public ushort m_nRenameCount;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
