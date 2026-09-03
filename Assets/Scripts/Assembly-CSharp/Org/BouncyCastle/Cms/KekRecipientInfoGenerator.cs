using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	internal class KekRecipientInfoGenerator : RecipientInfoGenerator
	{
		private static readonly CmsEnvelopedHelper Helper;

		private KeyParameter keyEncryptionKey;

		private string keyEncryptionKeyOID;

		private KekIdentifier kekIdentifier;

		private AlgorithmIdentifier keyEncryptionAlgorithm;

		internal KekIdentifier KekIdentifier
		{
			set
			{
			}
		}

		internal KeyParameter KeyEncryptionKey
		{
			set
			{
			}
		}

		internal string KeyEncryptionKeyOID
		{
			set
			{
			}
		}

		internal KekRecipientInfoGenerator()
		{
		}

		public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
		{
			return null;
		}

		private static AlgorithmIdentifier DetermineKeyEncAlg(string algorithm, KeyParameter key)
		{
			return null;
		}
	}
}
