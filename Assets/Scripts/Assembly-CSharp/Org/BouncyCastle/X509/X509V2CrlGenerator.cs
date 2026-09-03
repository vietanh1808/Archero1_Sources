using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.X509
{
	public class X509V2CrlGenerator
	{
		private readonly X509ExtensionsGenerator extGenerator;

		private V2TbsCertListGenerator tbsGen;

		private DerObjectIdentifier sigOID;

		private AlgorithmIdentifier sigAlgId;

		private string signatureAlgorithm;

		public IEnumerable SignatureAlgNames => null;

		public void Reset()
		{
		}

		public void SetIssuerDN(X509Name issuer)
		{
		}

		public void SetThisUpdate(DateTime date)
		{
		}

		public void SetNextUpdate(DateTime date)
		{
		}

		public void AddCrlEntry(BigInteger userCertificate, DateTime revocationDate, int reason)
		{
		}

		public void AddCrlEntry(BigInteger userCertificate, DateTime revocationDate, int reason, DateTime invalidityDate)
		{
		}

		public void AddCrlEntry(BigInteger userCertificate, DateTime revocationDate, X509Extensions extensions)
		{
		}

		public void AddCrl(X509Crl other)
		{
		}

		[Obsolete("Not needed if Generate used with an ISignatureFactory")]
		public void SetSignatureAlgorithm(string signatureAlgorithm)
		{
		}

		public void AddExtension(string oid, bool critical, Asn1Encodable extensionValue)
		{
		}

		public void AddExtension(DerObjectIdentifier oid, bool critical, Asn1Encodable extensionValue)
		{
		}

		public void AddExtension(string oid, bool critical, byte[] extensionValue)
		{
		}

		public void AddExtension(DerObjectIdentifier oid, bool critical, byte[] extensionValue)
		{
		}

		[Obsolete("Use Generate with an ISignatureFactory")]
		public X509Crl Generate(AsymmetricKeyParameter privateKey)
		{
			return null;
		}

		[Obsolete("Use Generate with an ISignatureFactory")]
		public X509Crl Generate(AsymmetricKeyParameter privateKey, SecureRandom random)
		{
			return null;
		}

		public X509Crl Generate(ISignatureFactory signatureCalculatorFactory)
		{
			return null;
		}

		private TbsCertificateList GenerateCertList()
		{
			return null;
		}

		private X509Crl GenerateJcaObject(TbsCertificateList tbsCrl, AlgorithmIdentifier algId, byte[] signature)
		{
			return null;
		}
	}
}
