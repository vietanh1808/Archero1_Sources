using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	public class SignerInfoGenerator
	{
		internal X509Certificate certificate;

		internal ISignatureFactory contentSigner;

		internal SignerIdentifier sigId;

		internal CmsAttributeTableGenerator signedGen;

		internal CmsAttributeTableGenerator unsignedGen;

		private bool isDirectSignature;

		internal SignerInfoGenerator(SignerIdentifier sigId, ISignatureFactory signerFactory)
		{
		}

		internal SignerInfoGenerator(SignerIdentifier sigId, ISignatureFactory signerFactory, bool isDirectSignature)
		{
		}

		internal SignerInfoGenerator(SignerIdentifier sigId, ISignatureFactory contentSigner, CmsAttributeTableGenerator signedGen, CmsAttributeTableGenerator unsignedGen)
		{
		}

		internal void setAssociatedCertificate(X509Certificate certificate)
		{
		}
	}
}
