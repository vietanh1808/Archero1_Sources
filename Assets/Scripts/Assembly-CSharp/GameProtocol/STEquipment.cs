using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STEquipment
	{
		public bool m_nChange;

		public CEquipmentItem[] m_vecEquipmentData;

		private List<int> containMatList;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
