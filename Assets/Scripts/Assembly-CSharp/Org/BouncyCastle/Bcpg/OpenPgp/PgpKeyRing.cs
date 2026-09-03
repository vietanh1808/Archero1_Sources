using System.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public abstract class PgpKeyRing : PgpObject
	{
		internal PgpKeyRing()
		{
		}

		internal static TrustPacket ReadOptionalTrustPacket(BcpgInputStream bcpgInput)
		{
			return null;
		}

		internal static IList ReadSignaturesAndTrust(BcpgInputStream bcpgInput)
		{
			return null;
		}

		internal static void ReadUserIDs(BcpgInputStream bcpgInput, out IList ids, out IList idTrusts, out IList idSigs)
		{
			ids = null;
			idTrusts = null;
			idSigs = null;
		}
	}
}
