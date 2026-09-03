using System.IO;

namespace GameProtocol
{
	public sealed class CReqSyncTimerestoreItems : CProtocolBase
	{
		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
