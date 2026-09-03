using System.IO;

namespace GameProtocol
{
	public sealed class CGameRelics : CProtocolBase
	{
		public enum RelicsType
		{
			info = 0,
			evolution = 1,
			star = 2,
			forge = 3,
			countInfo = 4
		}

		public ushort m_nType;

		public uint m_nTransID;

		public ulong m_nRowId;

		public uint m_nId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
