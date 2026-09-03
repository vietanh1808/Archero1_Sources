using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Tsp;

namespace Org.BouncyCastle.Tsp
{
	public class TimeStampResponse
	{
		private TimeStampResp resp;

		private TimeStampToken timeStampToken;

		public int Status => 0;

		public TimeStampToken TimeStampToken => null;

		public TimeStampResponse(TimeStampResp resp)
		{
		}

		public TimeStampResponse(byte[] resp)
		{
		}

		public TimeStampResponse(Stream input)
		{
		}

		private static TimeStampResp readTimeStampResp(Asn1InputStream input)
		{
			return null;
		}

		public string GetStatusString()
		{
			return null;
		}

		public PkiFailureInfo GetFailInfo()
		{
			return null;
		}

		public void Validate(TimeStampRequest request)
		{
		}

		public byte[] GetEncoded()
		{
			return null;
		}
	}
}
