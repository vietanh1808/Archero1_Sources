using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	public class DsaSigner : IDsaExt, IDsa
	{
		protected readonly IDsaKCalculator kCalculator;

		protected DsaKeyParameters key;

		protected SecureRandom random;

		public virtual string AlgorithmName => null;

		public virtual BigInteger Order => null;

		public DsaSigner()
		{
		}

		public DsaSigner(IDsaKCalculator kCalculator)
		{
		}

		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		public virtual BigInteger[] GenerateSignature(byte[] message)
		{
			return null;
		}

		public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
		{
			return false;
		}

		protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
		{
			return null;
		}

		protected virtual SecureRandom InitSecureRandom(bool needed, SecureRandom provided)
		{
			return null;
		}
	}
}
