using System.IO;

namespace GameProtocol
{
	public sealed class CGamblingShop : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nId;

		public uint m_nHeroId;

		public ushort m_nPos;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
