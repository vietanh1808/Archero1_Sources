using System.IO;

namespace GameProtocol
{
	public sealed class CRespWeaponSkin : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CWeaponSkin[] m_arraySkin;

		public CColorfulWeaponSkin[] m_arrayColorfulSkin;

		public ushort m_nCollectLevel;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
