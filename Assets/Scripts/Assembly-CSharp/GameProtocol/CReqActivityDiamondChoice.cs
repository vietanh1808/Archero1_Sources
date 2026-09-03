using System.IO;

namespace GameProtocol
{
	public sealed class CReqActivityDiamondChoice : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nId;

		public ushort[] m_vecChoiceIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
