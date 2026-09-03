using System.IO;

namespace GameProtocol
{
	public sealed class STUserMoney
	{
		public bool m_nChange;

		public uint m_nCoins;

		public int m_nDiamonds;

		public long m_nCoinsInt64;

		public int m_nStarDiamonds;

		public void ReadFromStream(BinaryReader reader, CCommonRespMsg.ReadOptions opt = null)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
