using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonGift
	{
		public ulong m_nStartTime;

		public uint m_nBuyTimes;

		public ulong m_nLastStartTime;

		public uint m_nTriggerTimes;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
