using System.IO;

namespace GameProtocol
{
	public sealed class STRestore
	{
		public bool m_nChange;

		public CRestoreItem[] m_vecRestoreData;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public CRestoreItem GetRestore(CRestoreItem.EItemIndex type)
		{
			return null;
		}

		public void Excute()
		{
		}
	}
}
