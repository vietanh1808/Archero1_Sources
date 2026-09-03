using System.IO;

namespace GameProtocol
{
	public sealed class CPvpBattleLog : STBaseRank
	{
		public bool m_bWin;

		public bool m_bPeak;

		public int m_nChangeScore;

		public new void ReadFromStream(BinaryReader reader)
		{
		}

		public new void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
