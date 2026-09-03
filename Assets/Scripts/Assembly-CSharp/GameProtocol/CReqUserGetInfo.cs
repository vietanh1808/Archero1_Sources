using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqUserGetInfo : CProtocolBase
	{
		public ulong m_nUserRawId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
