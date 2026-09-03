using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonFightBuff
	{
		public ushort m_nFighter;

		public uint m_nComponentId;

		public uint m_strBuffId;

		public ushort m_nBuffType;

		public long m_nStartTick;

		public long m_nTotalDuration;

		public long m_nDuration;

		public ushort m_nPreviousLayer;

		public ushort m_nLayer;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
