using System.IO;

namespace GameProtocol
{
	public sealed class CReqDailyIapReward : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nType;

		public string m_strExtra;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
