using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Cms
{
	public class PasswordRecipientInformation : RecipientInformation
	{
		private readonly PasswordRecipientInfo info;

		public virtual AlgorithmIdentifier KeyDerivationAlgorithm => null;

		internal PasswordRecipientInformation(PasswordRecipientInfo info, CmsSecureReadable secureReadable)
			: base(null, null)
		{
		}

		public override CmsTypedStream GetContentStream(ICipherParameters key)
		{
			return null;
		}
	}
}
