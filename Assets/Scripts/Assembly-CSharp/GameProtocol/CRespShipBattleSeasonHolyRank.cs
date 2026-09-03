using System.IO;

namespace GameProtocol
{
	public sealed class CRespShipBattleSeasonHolyRank : IProtocol
	{
		public short m_nStatusCode;

		public ushort m_nType;

		public CShipBattleRank[] m_arrayHolyRank;

		public ulong m_nValue;

		public uint m_nRank;

		public ushort m_nStage;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
