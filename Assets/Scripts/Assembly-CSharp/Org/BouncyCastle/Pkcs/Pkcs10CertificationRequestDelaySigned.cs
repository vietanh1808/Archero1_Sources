using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Pkcs
{
	public class Pkcs10CertificationRequestDelaySigned : Pkcs10CertificationRequest
	{
		protected Pkcs10CertificationRequestDelaySigned()
		{
		}

		public Pkcs10CertificationRequestDelaySigned(byte[] encoded)
		{
		}

		public Pkcs10CertificationRequestDelaySigned(Asn1Sequence seq)
		{
		}

		public Pkcs10CertificationRequestDelaySigned(Stream input)
		{
		}

		public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes, AsymmetricKeyParameter signingKey)
		{
		}

		public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes)
		{
		}

		public byte[] GetDataToSign()
		{
			return null;
		}

		public void SignRequest(byte[] signedData)
		{
		}

		public void SignRequest(DerBitString signedData)
		{
		}
	}
}
