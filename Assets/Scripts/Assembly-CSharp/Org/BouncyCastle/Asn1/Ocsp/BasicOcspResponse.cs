using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	public class BasicOcspResponse : Asn1Encodable
	{
		private readonly ResponseData tbsResponseData;

		private readonly AlgorithmIdentifier signatureAlgorithm;

		private readonly DerBitString signature;

		private readonly Asn1Sequence certs;

		public ResponseData TbsResponseData => null;

		public AlgorithmIdentifier SignatureAlgorithm => null;

		public DerBitString Signature => null;

		public Asn1Sequence Certs => null;

		public static BasicOcspResponse GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public static BasicOcspResponse GetInstance(object obj)
		{
			return null;
		}

		public BasicOcspResponse(ResponseData tbsResponseData, AlgorithmIdentifier signatureAlgorithm, DerBitString signature, Asn1Sequence certs)
		{
		}

		private BasicOcspResponse(Asn1Sequence seq)
		{
		}

		[Obsolete("Use TbsResponseData property instead")]
		public ResponseData GetTbsResponseData()
		{
			return null;
		}

		[Obsolete("Use SignatureAlgorithm property instead")]
		public AlgorithmIdentifier GetSignatureAlgorithm()
		{
			return null;
		}

		[Obsolete("Use Signature property instead")]
		public DerBitString GetSignature()
		{
			return null;
		}

		public byte[] GetSignatureOctets()
		{
			return null;
		}

		[Obsolete("Use Certs property instead")]
		public Asn1Sequence GetCerts()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
