using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	internal class EnvelopedDataHelper
	{
		private static readonly IDictionary BaseCipherNames;

		private static readonly IDictionary MacAlgNames;

		static EnvelopedDataHelper()
		{
		}

		public static object CreateContentCipher(bool forEncryption, ICipherParameters encKey, AlgorithmIdentifier encryptionAlgID)
		{
			return null;
		}

		public AlgorithmIdentifier GenerateEncryptionAlgID(DerObjectIdentifier encryptionOID, KeyParameter encKey, SecureRandom random)
		{
			return null;
		}

		public CipherKeyGenerator CreateKeyGenerator(DerObjectIdentifier algorithm, SecureRandom random)
		{
			return null;
		}
	}
}
