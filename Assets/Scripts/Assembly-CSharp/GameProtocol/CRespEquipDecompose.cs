using System.IO;

namespace GameProtocol
{
	public sealed class CRespEquipDecompose : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTotalCoins;

		public uint m_nGetCoins;

		public uint m_nMaterialID;

		public uint m_nMaterialCount;

		public CEquipmentItem[] arrayEquipItems;

		public long m_nTotalCoinsInt64;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
