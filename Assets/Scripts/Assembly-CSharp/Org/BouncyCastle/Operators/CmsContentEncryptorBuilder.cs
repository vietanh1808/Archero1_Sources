using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Operators
{
	public class CmsContentEncryptorBuilder
	{
		private static readonly IDictionary KeySizes;

		private readonly DerObjectIdentifier encryptionOID;

		private readonly int keySize;

		private readonly EnvelopedDataHelper helper;

		static CmsContentEncryptorBuilder()
		{
		}

		private static int GetKeySize(DerObjectIdentifier oid)
		{
			return 0;
		}

		public CmsContentEncryptorBuilder(DerObjectIdentifier encryptionOID)
		{
		}

		public CmsContentEncryptorBuilder(DerObjectIdentifier encryptionOID, int keySize)
		{
		}

		public ICipherBuilderWithKey Build()
		{
			return null;
		}
	}
}
