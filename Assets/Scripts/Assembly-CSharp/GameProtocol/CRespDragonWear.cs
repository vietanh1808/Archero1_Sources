using System;
using System.IO;

namespace GameProtocol
{
	[Serializable]
	public sealed class CRespDragonWear : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public bool m_bIsSync;

		public string m_strWearInfo;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
