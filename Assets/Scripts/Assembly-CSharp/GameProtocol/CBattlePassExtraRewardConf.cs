using System.IO;

namespace GameProtocol
{
	public sealed class CBattlePassExtraRewardConf
	{
		public ushort nExtraCnt;

		public ushort nExtraCondParam;

		public string strReward;

		public string strBigReward;

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
