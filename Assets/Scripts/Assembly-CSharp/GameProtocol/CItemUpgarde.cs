using System.IO;

namespace GameProtocol
{
	public sealed class CItemUpgarde : CProtocolBase
	{
		public uint m_nTransID;

		public ulong m_nRowID;

		public uint m_nCoins;

		public uint m_nDiamonds;

		public CMaterialItem[] arrayItems;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
