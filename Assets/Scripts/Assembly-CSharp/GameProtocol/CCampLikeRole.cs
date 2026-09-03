using System.IO;

namespace GameProtocol
{
	public sealed class CCampLikeRole : STViewRole
	{
		public uint m_nHonorValue;

		public ushort m_nStatus;

		public uint m_nBeLikeTimes;

		public uint[] m_vecUsingMedals;

		public new void ReadFromStream(BinaryReader reader)
		{
		}

		public new void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
