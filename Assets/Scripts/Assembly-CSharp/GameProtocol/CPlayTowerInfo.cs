using System.IO;

namespace GameProtocol
{
	public sealed class CPlayTowerInfo : CProtocolBase
	{
		public ushort m_nType;

		public bool m_bWin;

		public uint m_nTransID;

		public uint m_nId;

		public ushort m_nMode;

		public string m_strExtend;

		public uint m_nBloodPoint;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
