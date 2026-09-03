using System.IO;

namespace GameProtocol
{
	public sealed class STCampSeasonBlock
	{
		public ushort m_nCampIndex;

		public ulong m_nOwnerRawId;

		public ulong m_nResetTime;

		public bool m_bReceivedOnceReward;

		public uint m_nUsingSkinId;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
