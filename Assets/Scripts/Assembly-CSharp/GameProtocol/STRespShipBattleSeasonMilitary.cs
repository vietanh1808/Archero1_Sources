using System.IO;

namespace GameProtocol
{
	public sealed class STRespShipBattleSeasonMilitary : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nMilitary;

		public uint m_nMilitaryExp;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
