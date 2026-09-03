using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Crypto.Signers
{
	public class SM2Signer : ISigner
	{
		private readonly IDsaKCalculator kCalculator;

		private readonly SM3Digest digest;

		private readonly IDsaEncoding encoding;

		private ECDomainParameters ecParams;

		private ECPoint pubPoint;

		private ECKeyParameters ecKey;

		private byte[] z;

		public virtual string AlgorithmName => null;

		public SM2Signer()
		{
		}

		public SM2Signer(IDsaEncoding encoding)
		{
		}

		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		public virtual void Update(byte b)
		{
		}

		public virtual void BlockUpdate(byte[] buf, int off, int len)
		{
		}

		public virtual bool VerifySignature(byte[] signature)
		{
			return false;
		}

		public virtual void Reset()
		{
		}

		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		private bool VerifySignature(BigInteger r, BigInteger s)
		{
			return false;
		}

		private byte[] GetZ(byte[] userID)
		{
			return null;
		}

		private void AddUserID(IDigest digest, byte[] userID)
		{
		}

		private void AddFieldElement(IDigest digest, ECFieldElement v)
		{
		}

		protected virtual BigInteger CalculateE(byte[] message)
		{
			return null;
		}

		protected virtual ECMultiplier CreateBasePointMultiplier()
		{
			return null;
		}
	}
}
