using System.IO;

namespace GameProtocol
{
	public sealed class CDailyGiftHeroData
	{
		public string m_strIapId;

		public string m_strJsonRewards;

		public string m_strJsonHeroFragment;

		public ushort m_nBuyCount;

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
