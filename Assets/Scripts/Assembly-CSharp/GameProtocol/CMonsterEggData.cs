using System.IO;

namespace GameProtocol
{
	public sealed class CMonsterEggData
	{
		public bool m_nChange;

		public CMonsterEgg[] m_vecMonsterEgg;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
