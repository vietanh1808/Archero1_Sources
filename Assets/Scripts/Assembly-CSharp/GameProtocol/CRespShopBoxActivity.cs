using System.IO;

namespace GameProtocol
{
	public sealed class CRespShopBoxActivity : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CBoxActivityInfo[] m_vecBoxActivitys;

		public string strNewEquipIds;

		public ushort m_nGameLevel;

		public ushort m_nType;

		public CBoxGemActivityInfo[] m_vecBoxGemActivitys;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private bool IsValid()
		{
			return false;
		}

		public long GetEndTime()
		{
			return 0L;
		}

		public bool GetCanShow()
		{
			return false;
		}
	}
}
