using System.IO;

namespace GameProtocol
{
	public sealed class CReqCampBlock : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nBlockIndex;

		public uint m_nHeroId;

		public uint m_nNum;

		public uint m_nSuperNum;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
