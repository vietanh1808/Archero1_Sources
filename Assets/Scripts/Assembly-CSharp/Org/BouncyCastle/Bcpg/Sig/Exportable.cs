namespace Org.BouncyCastle.Bcpg.Sig
{
	public class Exportable : SignatureSubpacket
	{
		private static byte[] BooleanToByteArray(bool val)
		{
			return null;
		}

		public Exportable(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public Exportable(bool critical, bool isExportable)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public bool IsExportable()
		{
			return false;
		}
	}
}
