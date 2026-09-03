using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	public class PkixBuilderParameters : PkixParameters
	{
		private int maxPathLength;

		private ISet excludedCerts;

		public virtual int MaxPathLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static PkixBuilderParameters GetInstance(PkixParameters pkixParams)
		{
			return null;
		}

		public PkixBuilderParameters(ISet trustAnchors, IX509Selector targetConstraints)
			: base(null)
		{
		}

		public virtual ISet GetExcludedCerts()
		{
			return null;
		}

		public virtual void SetExcludedCerts(ISet excludedCerts)
		{
		}

		protected override void SetParams(PkixParameters parameters)
		{
		}

		public override object Clone()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
