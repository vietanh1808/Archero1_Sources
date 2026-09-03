using System.IO;

namespace GameProtocol
{
	public sealed class STReqFarmPvpInfo : CProtocolBase
	{
		public ushort m_nType;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
