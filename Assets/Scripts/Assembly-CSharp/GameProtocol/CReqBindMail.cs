using System.IO;

namespace GameProtocol
{
	public sealed class CReqBindMail : CProtocolBase
	{
		public string m_strEmailAddress;

		public ushort m_nLanguage;

		public ushort m_nOs;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
