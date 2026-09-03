using System.IO;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Utilities.IO.Pem;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.OpenSsl
{
	public class PemReader : Org.BouncyCastle.Utilities.IO.Pem.PemReader
	{
		private readonly IPasswordFinder pFinder;

		static PemReader()
		{
		}

		public PemReader(TextReader reader)
			: base(null)
		{
		}

		public PemReader(TextReader reader, IPasswordFinder pFinder)
			: base(null)
		{
		}

		public object ReadObject()
		{
			return null;
		}

		private AsymmetricKeyParameter ReadRsaPublicKey(PemObject pemObject)
		{
			return null;
		}

		private AsymmetricKeyParameter ReadPublicKey(PemObject pemObject)
		{
			return null;
		}

		private X509Certificate ReadCertificate(PemObject pemObject)
		{
			return null;
		}

		private X509Crl ReadCrl(PemObject pemObject)
		{
			return null;
		}

		private Pkcs10CertificationRequest ReadCertificateRequest(PemObject pemObject)
		{
			return null;
		}

		private IX509AttributeCertificate ReadAttributeCertificate(PemObject pemObject)
		{
			return null;
		}

		private ContentInfo ReadPkcs7(PemObject pemObject)
		{
			return null;
		}

		private object ReadPrivateKey(PemObject pemObject)
		{
			return null;
		}

		private static X9ECParameters GetCurveParameters(string name)
		{
			return null;
		}
	}
}
