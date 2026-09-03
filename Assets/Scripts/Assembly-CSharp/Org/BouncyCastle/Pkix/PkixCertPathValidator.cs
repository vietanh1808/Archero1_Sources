using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkix
{
	public class PkixCertPathValidator
	{
		public virtual PkixCertPathValidatorResult Validate(PkixCertPath certPath, PkixParameters paramsPkix)
		{
			return null;
		}

		internal static void CheckCertificate(X509Certificate cert)
		{
		}
	}
}
