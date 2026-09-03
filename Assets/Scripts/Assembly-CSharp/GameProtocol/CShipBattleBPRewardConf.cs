using System.IO;

namespace GameProtocol
{
	public sealed class CShipBattleBPRewardConf
	{
		public uint nID;

		public ushort nConditionParam;

		public CRewardItem[] vecRewardInfo;

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
