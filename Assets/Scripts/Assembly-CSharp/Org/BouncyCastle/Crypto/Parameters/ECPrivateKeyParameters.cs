using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class ECPrivateKeyParameters : ECKeyParameters
	{
		private readonly BigInteger d;

		public BigInteger D => null;

		public ECPrivateKeyParameters(BigInteger d, ECDomainParameters parameters)
			: base((string)null, false, (ECDomainParameters)null)
		{
		}

		[Obsolete("Use version with explicit 'algorithm' parameter")]
		public ECPrivateKeyParameters(BigInteger d, DerObjectIdentifier publicKeyParamSet)
			: base((string)null, false, (ECDomainParameters)null)
		{
		}

		public ECPrivateKeyParameters(string algorithm, BigInteger d, ECDomainParameters parameters)
			: base((string)null, false, (ECDomainParameters)null)
		{
		}

		public ECPrivateKeyParameters(string algorithm, BigInteger d, DerObjectIdentifier publicKeyParamSet)
			: base((string)null, false, (ECDomainParameters)null)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		protected bool Equals(ECPrivateKeyParameters other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
