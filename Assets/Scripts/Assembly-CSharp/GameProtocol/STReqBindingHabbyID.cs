using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class STReqBindingHabbyID : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public string m_strAuthCode;

		public string m_strLanguage;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
