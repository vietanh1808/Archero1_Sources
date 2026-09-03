using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.X509
{
	public class X509V3CertificateGenerator
	{
		private readonly X509ExtensionsGenerator extGenerator;

		private V3TbsCertificateGenerator tbsGen;

		private DerObjectIdentifier sigOid;

		private AlgorithmIdentifier sigAlgId;

		private string signatureAlgorithm;

		public IEnumerable SignatureAlgNames => null;

		public void Reset()
		{
		}

		public void SetSerialNumber(BigInteger serialNumber)
		{
		}

		public void SetIssuerDN(X509Name issuer)
		{
		}

		public void SetNotBefore(DateTime date)
		{
		}

		public void SetNotAfter(DateTime date)
		{
		}

		public void SetSubjectDN(X509Name subject)
		{
		}

		public void SetPublicKey(AsymmetricKeyParameter publicKey)
		{
		}

		[Obsolete("Not needed if Generate used with an ISignatureFactory")]
		public void SetSignatureAlgorithm(string signatureAlgorithm)
		{
		}

		public void SetSubjectUniqueID(bool[] uniqueID)
		{
		}

		public void SetIssuerUniqueID(bool[] uniqueID)
		{
		}

		private DerBitString booleanToBitString(bool[] id)
		{
			return null;
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

		public void CopyAndAddExtension(string oid, bool critical, X509Certificate cert)
		{
		}

		public void CopyAndAddExtension(DerObjectIdentifier oid, bool critical, X509Certificate cert)
		{
		}

		[Obsolete("Use Generate with an ISignatureFactory")]
		public X509Certificate Generate(AsymmetricKeyParameter privateKey)
		{
			return null;
		}

		[Obsolete("Use Generate with an ISignatureFactory")]
		public X509Certificate Generate(AsymmetricKeyParameter privateKey, SecureRandom random)
		{
			return null;
		}

		public X509Certificate Generate(ISignatureFactory signatureCalculatorFactory)
		{
			return null;
		}

		private X509Certificate GenerateJcaObject(TbsCertificateStructure tbsCert, AlgorithmIdentifier sigAlg, byte[] signature)
		{
			return null;
		}
	}
}
