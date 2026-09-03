using System;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Ocsp
{
	public class RevokedStatus : CertificateStatus
	{
		internal readonly RevokedInfo info;

		public DateTime RevocationTime => default;

		public bool HasRevocationReason => false;

		public int RevocationReason => 0;

		public RevokedStatus(RevokedInfo info)
		{
		}

		public RevokedStatus(DateTime revocationDate, int reason)
		{
		}
	}
}
