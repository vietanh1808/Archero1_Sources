namespace Org.BouncyCastle.Bcpg.Sig
{
	public class KeyFlags : SignatureSubpacket
	{
		public const int CertifyOther = 1;

		public const int SignData = 2;

		public const int EncryptComms = 4;

		public const int EncryptStorage = 8;

		public const int Split = 16;

		public const int Authentication = 32;

		public const int Shared = 128;

		public int Flags => 0;

		private static byte[] IntToByteArray(int v)
		{
			return null;
		}

		public KeyFlags(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public KeyFlags(bool critical, int flags)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}
	}
}
