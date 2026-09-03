using System.IO;

namespace GameProtocol
{
	public sealed class CReqFirstCharge : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nRewardId;

		public ushort m_nKey;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
