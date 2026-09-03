using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms
{
	public class CmsAuthenticatedDataStreamGenerator : CmsAuthenticatedGenerator
	{
		private class CmsAuthenticatedDataOutputStream : BaseOutputStream
		{
			private readonly Stream macStream;

			private readonly IMac mac;

			private readonly BerSequenceGenerator cGen;

			private readonly BerSequenceGenerator authGen;

			private readonly BerSequenceGenerator eiGen;

			public CmsAuthenticatedDataOutputStream(Stream macStream, IMac mac, BerSequenceGenerator cGen, BerSequenceGenerator authGen, BerSequenceGenerator eiGen)
			{
			}

			public override void WriteByte(byte b)
			{
			}

			public override void Write(byte[] bytes, int off, int len)
			{
			}

			public override void Close()
			{
			}
		}

		private int _bufferSize;

		private bool _berEncodeRecipientSet;

		public CmsAuthenticatedDataStreamGenerator()
		{
		}

		public CmsAuthenticatedDataStreamGenerator(SecureRandom rand)
		{
		}

		public void SetBufferSize(int bufferSize)
		{
		}

		public void SetBerEncodeRecipients(bool berEncodeRecipientSet)
		{
		}

		private Stream Open(Stream outStr, string macOid, CipherKeyGenerator keyGen)
		{
			return null;
		}

		protected Stream Open(Stream outStr, AlgorithmIdentifier macAlgId, ICipherParameters cipherParameters, Asn1EncodableVector recipientInfos)
		{
			return null;
		}

		public Stream Open(Stream outStr, string encryptionOid)
		{
			return null;
		}

		public Stream Open(Stream outStr, string encryptionOid, int keySize)
		{
			return null;
		}
	}
}
