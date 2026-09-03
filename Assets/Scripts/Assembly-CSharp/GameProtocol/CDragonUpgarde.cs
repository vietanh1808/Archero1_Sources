using System.IO;

namespace GameProtocol
{
	public sealed class CDragonUpgarde : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ulong m_nRowId;

		public ushort m_nIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
