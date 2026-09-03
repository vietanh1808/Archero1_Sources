using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	internal class KeyAgreeRecipientInfoGenerator : RecipientInfoGenerator
	{
		private static readonly CmsEnvelopedHelper Helper;

		private DerObjectIdentifier keyAgreementOID;

		private DerObjectIdentifier keyEncryptionOID;

		private IList recipientCerts;

		private AsymmetricCipherKeyPair senderKeyPair;

		internal DerObjectIdentifier KeyAgreementOID
		{
			set
			{
			}
		}

		internal DerObjectIdentifier KeyEncryptionOID
		{
			set
			{
			}
		}

		internal ICollection RecipientCerts
		{
			set
			{
			}
		}

		internal AsymmetricCipherKeyPair SenderKeyPair
		{
			set
			{
			}
		}

		internal KeyAgreeRecipientInfoGenerator()
		{
		}

		public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
		{
			return null;
		}

		private static OriginatorPublicKey CreateOriginatorPublicKey(AsymmetricKeyParameter publicKey)
		{
			return null;
		}
	}
}
