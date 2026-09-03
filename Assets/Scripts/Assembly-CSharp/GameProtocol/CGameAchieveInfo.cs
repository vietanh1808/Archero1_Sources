using System.IO;

namespace GameProtocol
{
	public sealed class CGameAchieveInfo : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nId;

		public uint m_nTransID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
