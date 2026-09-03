using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Pkix
{
	public class PkixCertPathBuilderResult : PkixCertPathValidatorResult
	{
		private PkixCertPath certPath;

		public PkixCertPath CertPath => null;

		public PkixCertPathBuilderResult(PkixCertPath certPath, TrustAnchor trustAnchor, PkixPolicyNode policyTree, AsymmetricKeyParameter subjectPublicKey)
			: base(null, null, null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
