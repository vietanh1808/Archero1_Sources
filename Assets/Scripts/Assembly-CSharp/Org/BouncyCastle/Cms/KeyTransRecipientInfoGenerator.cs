using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	public class KeyTransRecipientInfoGenerator : RecipientInfoGenerator
	{
		private static readonly CmsEnvelopedHelper Helper;

		private TbsCertificateStructure recipientTbsCert;

		private AsymmetricKeyParameter recipientPublicKey;

		private Asn1OctetString subjectKeyIdentifier;

		private SubjectPublicKeyInfo info;

		private IssuerAndSerialNumber issuerAndSerialNumber;

		private SecureRandom random;

		internal X509Certificate RecipientCert
		{
			set
			{
			}
		}

		internal AsymmetricKeyParameter RecipientPublicKey
		{
			set
			{
			}
		}

		internal Asn1OctetString SubjectKeyIdentifier
		{
			set
			{
			}
		}

		protected virtual AlgorithmIdentifier AlgorithmDetails => null;

		internal KeyTransRecipientInfoGenerator()
		{
		}

		protected KeyTransRecipientInfoGenerator(IssuerAndSerialNumber issuerAndSerialNumber)
		{
		}

		protected KeyTransRecipientInfoGenerator(byte[] subjectKeyIdentifier)
		{
		}

		public RecipientInfo Generate(KeyParameter contentEncryptionKey, SecureRandom random)
		{
			return null;
		}

		protected virtual byte[] GenerateWrappedKey(KeyParameter contentEncryptionKey)
		{
			return null;
		}
	}
}
