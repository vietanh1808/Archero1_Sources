using System.IO;

namespace GameProtocol
{
	public sealed class CDiamondToCoin : CProtocolBase
	{
		public uint m_nTransID;

		public uint m_nCoins;

		public uint m_nDiamonds;

		public bool m_bAd;

		public ushort m_nType;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
