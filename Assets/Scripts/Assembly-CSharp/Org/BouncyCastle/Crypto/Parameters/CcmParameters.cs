using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	[Obsolete("Use AeadParameters")]
	public class CcmParameters : AeadParameters
	{
		public CcmParameters(KeyParameter key, int macSize, byte[] nonce, byte[] associatedText)
			: base(null, 0, null)
		{
		}
	}
}
