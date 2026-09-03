using System.IO;

namespace GameProtocol
{
	public sealed class CShipBattleAchieveData
	{
		public uint nType;

		public uint nCount;

		public uint nRewardIdx;

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
