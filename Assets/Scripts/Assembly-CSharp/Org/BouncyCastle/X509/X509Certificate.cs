using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.X509
{
	public class X509Certificate : X509ExtensionBase
	{
		private readonly X509CertificateStructure c;

		private readonly BasicConstraints basicConstraints;

		private readonly bool[] keyUsage;

		private bool hashValueSet;

		private int hashValue;

		public virtual X509CertificateStructure CertificateStructure => null;

		public virtual bool IsValidNow => false;

		public virtual int Version => 0;

		public virtual BigInteger SerialNumber => null;

		public virtual X509Name IssuerDN => null;

		public virtual X509Name SubjectDN => null;

		public virtual DateTime NotBefore => default;

		public virtual DateTime NotAfter => default;

		public virtual string SigAlgName => null;

		public virtual string SigAlgOid => null;

		public virtual DerBitString IssuerUniqueID => null;

		public virtual DerBitString SubjectUniqueID => null;

		protected X509Certificate()
		{
		}

		public X509Certificate(X509CertificateStructure c)
		{
		}

		public virtual bool IsValid(DateTime time)
		{
			return false;
		}

		public virtual void CheckValidity()
		{
		}

		public virtual void CheckValidity(DateTime time)
		{
		}

		public virtual byte[] GetTbsCertificate()
		{
			return null;
		}

		public virtual byte[] GetSignature()
		{
			return null;
		}

		public virtual byte[] GetSigAlgParams()
		{
			return null;
		}

		public virtual bool[] GetKeyUsage()
		{
			return null;
		}

		public virtual IList GetExtendedKeyUsage()
		{
			return null;
		}

		public virtual int GetBasicConstraints()
		{
			return 0;
		}

		public virtual ICollection GetSubjectAlternativeNames()
		{
			return null;
		}

		public virtual ICollection GetIssuerAlternativeNames()
		{
			return null;
		}

		protected virtual ICollection GetAlternativeNames(string oid)
		{
			return null;
		}

		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		public virtual AsymmetricKeyParameter GetPublicKey()
		{
			return null;
		}

		public virtual byte[] GetEncoded()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual void Verify(AsymmetricKeyParameter key)
		{
		}

		public virtual void Verify(IVerifierFactoryProvider verifierProvider)
		{
		}

		protected virtual void CheckSignature(IVerifierFactory verifier)
		{
		}

		private static bool IsAlgIDEqual(AlgorithmIdentifier id1, AlgorithmIdentifier id2)
		{
			return false;
		}
	}
}
