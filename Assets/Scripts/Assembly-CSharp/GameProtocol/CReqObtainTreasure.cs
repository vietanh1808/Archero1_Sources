using System.IO;

namespace GameProtocol
{
	public sealed class CReqObtainTreasure : CProtocolBase
	{
		public uint m_nTransID;

		public uint m_nCoin;

		public CEquipmentItem m_stTreasureItems;

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
