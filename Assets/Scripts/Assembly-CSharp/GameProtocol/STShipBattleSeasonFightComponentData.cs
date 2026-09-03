using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonFightComponentData
	{
		public uint m_nTabId;

		public ushort m_nLevel;

		public uint m_nSkin;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
