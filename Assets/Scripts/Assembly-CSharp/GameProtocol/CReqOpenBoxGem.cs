using System.IO;

namespace GameProtocol
{
	public sealed class CReqOpenBoxGem : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public ushort m_nAdSkip;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
