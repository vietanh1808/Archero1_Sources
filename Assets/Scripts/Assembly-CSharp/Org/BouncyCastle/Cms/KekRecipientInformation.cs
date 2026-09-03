using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Cms
{
	public class KekRecipientInformation : RecipientInformation
	{
		private KekRecipientInfo info;

		internal KekRecipientInformation(KekRecipientInfo info, CmsSecureReadable secureReadable)
			: base(null, null)
		{
		}

		public override CmsTypedStream GetContentStream(ICipherParameters key)
		{
			return null;
		}
	}
}
