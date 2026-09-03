using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	public class CmsSignedData
	{
		private static readonly CmsSignedHelper Helper;

		private readonly CmsProcessable signedContent;

		private SignedData signedData;

		private ContentInfo contentInfo;

		private SignerInformationStore signerInfoStore;

		private IX509Store attrCertStore;

		private IX509Store certificateStore;

		private IX509Store crlStore;

		private IDictionary hashes;

		public int Version => 0;

		[Obsolete("Use 'SignedContentType' property instead.")]
		public string SignedContentTypeOid => null;

		public DerObjectIdentifier SignedContentType => null;

		public CmsProcessable SignedContent => null;

		public ContentInfo ContentInfo => null;

		private CmsSignedData(CmsSignedData c)
		{
		}

		public CmsSignedData(byte[] sigBlock)
		{
		}

		public CmsSignedData(CmsProcessable signedContent, byte[] sigBlock)
		{
		}

		public CmsSignedData(IDictionary hashes, byte[] sigBlock)
		{
		}

		public CmsSignedData(CmsProcessable signedContent, Stream sigData)
		{
		}

		public CmsSignedData(Stream sigData)
		{
		}

		public CmsSignedData(CmsProcessable signedContent, ContentInfo sigData)
		{
		}

		public CmsSignedData(IDictionary hashes, ContentInfo sigData)
		{
		}

		public CmsSignedData(ContentInfo sigData)
		{
		}

		public SignerInformationStore GetSignerInfos()
		{
			return null;
		}

		public IX509Store GetAttributeCertificates(string type)
		{
			return null;
		}

		public IX509Store GetCertificates(string type)
		{
			return null;
		}

		public IX509Store GetCrls(string type)
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public static CmsSignedData ReplaceSigners(CmsSignedData signedData, SignerInformationStore signerInformationStore)
		{
			return null;
		}

		public static CmsSignedData ReplaceCertificatesAndCrls(CmsSignedData signedData, IX509Store x509Certs, IX509Store x509Crls, IX509Store x509AttrCerts)
		{
			return null;
		}
	}
}
