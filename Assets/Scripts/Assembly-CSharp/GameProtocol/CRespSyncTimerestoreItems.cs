using System.IO;

namespace GameProtocol
{
	public sealed class CRespSyncTimerestoreItems : IProtocol
	{
		public CRestoreItem[] m_vecTimeRestoreData;

		public ulong m_serverTime;

		public ushort m_nExtraNormalDiamondItem;

		public ushort m_nExtraLargeDiamondItem;

		public ushort m_nExtraMixBoxItem;

		public ushort m_nExtraDragonBoxItem;

		public ushort m_nRelicsBoxItem;

		public ushort m_nEquipSBoxItem;

		public uint m_nWorkerBoxItem;

		public uint m_nPetBoxItem;

		public uint m_nImprintBoxItem;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
