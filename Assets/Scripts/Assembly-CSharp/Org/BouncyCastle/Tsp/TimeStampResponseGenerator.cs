using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tsp
{
	public class TimeStampResponseGenerator
	{
		private class FailInfo : DerBitString
		{
			internal FailInfo(int failInfoValue)
				: base(null, 0)
			{
			}
		}

		private PkiStatus status;

		private Asn1EncodableVector statusStrings;

		private int failInfo;

		private TimeStampTokenGenerator tokenGenerator;

		private IList acceptedAlgorithms;

		private IList acceptedPolicies;

		private IList acceptedExtensions;

		public TimeStampResponseGenerator(TimeStampTokenGenerator tokenGenerator, IList acceptedAlgorithms)
		{
		}

		public TimeStampResponseGenerator(TimeStampTokenGenerator tokenGenerator, IList acceptedAlgorithms, IList acceptedPolicy)
		{
		}

		public TimeStampResponseGenerator(TimeStampTokenGenerator tokenGenerator, IList acceptedAlgorithms, IList acceptedPolicies, IList acceptedExtensions)
		{
		}

		private void AddStatusString(string statusString)
		{
		}

		private void SetFailInfoField(int field)
		{
		}

		private PkiStatusInfo GetPkiStatusInfo()
		{
			return null;
		}

		public TimeStampResponse Generate(TimeStampRequest request, BigInteger serialNumber, DateTime genTime)
		{
			return null;
		}

		public TimeStampResponse Generate(TimeStampRequest request, BigInteger serialNumber, DateTimeObject genTime)
		{
			return null;
		}

		public TimeStampResponse GenerateFailResponse(PkiStatus status, int failInfoField, string statusString)
		{
			return null;
		}
	}
}
