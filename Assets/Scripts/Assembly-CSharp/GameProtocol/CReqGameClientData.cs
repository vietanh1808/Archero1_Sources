using System.IO;

namespace GameProtocol
{
	public sealed class CReqGameClientData : CProtocolBase
	{
		public ushort m_nType;

		public string m_strClientData;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
