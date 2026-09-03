using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	public class OcspReqGenerator
	{
		private class RequestObject
		{
			internal CertificateID certId;

			internal X509Extensions extensions;

			public RequestObject(CertificateID certId, X509Extensions extensions)
			{
			}

			public Request ToRequest()
			{
				return null;
			}
		}

		private IList list;

		private GeneralName requestorName;

		private X509Extensions requestExtensions;

		public IEnumerable SignatureAlgNames => null;

		public void AddRequest(CertificateID certId)
		{
		}

		public void AddRequest(CertificateID certId, X509Extensions singleRequestExtensions)
		{
		}

		public void SetRequestorName(X509Name requestorName)
		{
		}

		public void SetRequestorName(GeneralName requestorName)
		{
		}

		public void SetRequestExtensions(X509Extensions requestExtensions)
		{
		}

		private OcspReq GenerateRequest(DerObjectIdentifier signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain, SecureRandom random)
		{
			return null;
		}

		public OcspReq Generate()
		{
			return null;
		}

		public OcspReq Generate(string signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain)
		{
			return null;
		}

		public OcspReq Generate(string signingAlgorithm, AsymmetricKeyParameter privateKey, X509Certificate[] chain, SecureRandom random)
		{
			return null;
		}
	}
}
