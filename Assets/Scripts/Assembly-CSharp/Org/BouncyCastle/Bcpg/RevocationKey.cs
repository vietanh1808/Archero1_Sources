namespace Org.BouncyCastle.Bcpg
{
	public class RevocationKey : SignatureSubpacket
	{
		public virtual RevocationKeyTag SignatureClass => (RevocationKeyTag)0;

		public virtual PublicKeyAlgorithmTag Algorithm => (PublicKeyAlgorithmTag)0;

		public RevocationKey(bool isCritical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public RevocationKey(bool isCritical, RevocationKeyTag signatureClass, PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		private static byte[] CreateData(RevocationKeyTag signatureClass, PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
		{
			return null;
		}

		public virtual byte[] GetFingerprint()
		{
			return null;
		}
	}
}
