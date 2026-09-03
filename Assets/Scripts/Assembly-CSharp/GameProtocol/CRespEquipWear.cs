using System;
using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRespEquipWear : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nShow;

		public bool m_bIsSync;

		public Dictionary<ushort, string> m_mapWearScheme;

		public ushort m_nLayerShowType;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
