using System.IO;

namespace GameProtocol
{
	public sealed class CReqWeaponSkin : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nSkinId;

		public ushort m_nSkinType;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
