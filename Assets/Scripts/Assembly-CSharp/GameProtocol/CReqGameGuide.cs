using System.IO;

namespace GameProtocol
{
	public sealed class CReqGameGuide : CProtocolBase
	{
		public ushort m_nType;

		public string m_strGuide;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
