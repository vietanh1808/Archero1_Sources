using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqUserUpdateInfo : CProtocolBase
	{
		public string m_strNickName;

		public uint m_nHeadId;

		public uint m_nHeadFrameId;

		public string m_strAppLanguage;

		public uint m_nTransID;

		public ushort m_nType;

		public uint m_nCardThemeId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
