using System.IO;

namespace GameProtocol
{
	public sealed class STPetInfo
	{
		public ulong m_nRowId;

		public uint m_nId;

		public ushort m_nLevel;

		public ushort m_nStar;

		public ushort m_nStatus;

		public ushort[] m_vecSkillLv;

		public uint[] m_vecInheritSkill;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
