using System.IO;

namespace GameProtocol
{
	public sealed class STArtifactTrialTalent
	{
		public uint m_nID;

		public uint m_nLevel;

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

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
