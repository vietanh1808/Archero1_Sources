using System.IO;

namespace GameProtocol
{
	public sealed class STUserInfo
	{
		public bool m_nChange;

		public uint m_nTransID;

		public STUserMoney m_nUserMoney;

		public STUserLevel m_nUserLevel;

		public STUserResource m_nUserResource;

		public void ReadFromStream(BinaryReader reader, CCommonRespMsg.ReadOptions opt = null)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
