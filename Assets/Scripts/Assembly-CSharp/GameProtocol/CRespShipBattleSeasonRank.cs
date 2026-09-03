using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonRank : IProtocol
	{
		public short m_nStatusCode;

		public ushort m_nType;

		public CShipBattleBaseRank[] m_arrayLifeRank;

		public CShipBattleBaseRank[] m_arrayTalentRank;

		public CShipBattleBaseRank[] m_arrayFireRank;

		public CShipBattleBaseRank[] m_arrayActivityRank;

		public ulong m_nLifeValue;

		public uint m_nLifeRank;

		public ulong m_nTalentValue;

		public uint m_nTalentRank;

		public ulong m_nFireValue;

		public uint m_nFireRank;

		public ulong m_nActivityValue;

		public uint m_nActivityRank;

		public ushort m_nActivityType;

		public CShipBattleBaseRank[] m_arrayPvpRank;

		public ulong m_nPvpValue;

		public uint m_nPvpRank;

		public CShipBattleRank[] m_arrayBigMapRank;

		public CShipBattleMultipleEventsConf m_stCostLifeRankConf;

		public CShipBattleMultipleEventsConf m_stFireRankConf;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
