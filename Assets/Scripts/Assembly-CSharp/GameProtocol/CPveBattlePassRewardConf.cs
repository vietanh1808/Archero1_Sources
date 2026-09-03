using System.IO;

namespace GameProtocol
{
	public sealed class CPveBattlePassRewardConf
	{
		public uint nId;

		public ushort nCondType;

		public ushort nParam;

		public string[] m_arrRewardInfo;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
