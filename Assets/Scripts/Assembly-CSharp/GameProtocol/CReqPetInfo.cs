using System.IO;

namespace GameProtocol
{
	public sealed class CReqPetInfo : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nPetId;

		public ushort m_nStatus;

		public uint m_nSkillId;

		public ushort m_nPos;

		public uint m_nInheritPetId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
