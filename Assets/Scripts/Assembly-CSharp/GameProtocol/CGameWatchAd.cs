using System.IO;

namespace GameProtocol
{
	public sealed class CGameWatchAd : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nAdId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
