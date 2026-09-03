using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRespEquipWish : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strEquipList;

		public string m_strConfig;

		public string m_strHideEquipList;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
