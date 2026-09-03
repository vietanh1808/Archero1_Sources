using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CReqWing : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nWingId;

		public ulong m_nRowID;

		public Dictionary<ushort, ulong> m_mapAttach;

		public ushort m_nNum;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
