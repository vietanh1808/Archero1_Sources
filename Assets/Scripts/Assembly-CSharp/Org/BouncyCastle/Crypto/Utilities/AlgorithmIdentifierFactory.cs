using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Utilities
{
	public class AlgorithmIdentifierFactory
	{
		public static readonly DerObjectIdentifier IDEA_CBC;

		public static readonly DerObjectIdentifier CAST5_CBC;

		private static readonly short[] rc2Table;

		public static AlgorithmIdentifier GenerateEncryptionAlgID(DerObjectIdentifier encryptionOID, int keySize, SecureRandom random)
		{
			return null;
		}
	}
}
