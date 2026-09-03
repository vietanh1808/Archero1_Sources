using System.IO;

namespace GameProtocol
{
	public sealed class CReqDailyIapGift : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public uint m_nSelectHeroIndex;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
