using System.IO;

namespace GameProtocol
{
	public sealed class CReqLoginGift : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort m_nRewardIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
