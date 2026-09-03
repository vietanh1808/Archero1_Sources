using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class DefaultTlsSrpGroupVerifier : TlsSrpGroupVerifier
	{
		protected static readonly IList DefaultGroups;

		protected readonly IList mGroups;

		static DefaultTlsSrpGroupVerifier()
		{
		}

		public DefaultTlsSrpGroupVerifier()
		{
		}

		public DefaultTlsSrpGroupVerifier(IList groups)
		{
		}

		public virtual bool Accept(Srp6GroupParameters group)
		{
			return false;
		}

		protected virtual bool AreGroupsEqual(Srp6GroupParameters a, Srp6GroupParameters b)
		{
			return false;
		}

		protected virtual bool AreParametersEqual(BigInteger a, BigInteger b)
		{
			return false;
		}
	}
}
