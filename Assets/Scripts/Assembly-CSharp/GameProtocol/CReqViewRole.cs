using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CReqViewRole : CProtocolBase
	{
		public HashSet<ulong> m_vecUserId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
