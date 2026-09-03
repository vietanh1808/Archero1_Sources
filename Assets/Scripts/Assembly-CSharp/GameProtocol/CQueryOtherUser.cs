using System.IO;

namespace GameProtocol
{
	public sealed class CQueryOtherUser : CProtocolBase
	{
		public ulong m_nUserID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
