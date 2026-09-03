using System.IO;

namespace GameProtocol
{
	public sealed class CReqEquipTotem : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public uint m_nTomtemId;

		public ulong m_nRowID;

		public uint m_nNum;

		public ulong[] m_arrayDecomposeRowIds;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
