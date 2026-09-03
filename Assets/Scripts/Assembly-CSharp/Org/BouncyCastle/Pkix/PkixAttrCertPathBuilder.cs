using System;
using System.Collections;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkix
{
	public class PkixAttrCertPathBuilder
	{
		private Exception certPathException;

		public virtual PkixCertPathBuilderResult Build(PkixBuilderParameters pkixParams)
		{
			return null;
		}

		private PkixCertPathBuilderResult Build(IX509AttributeCertificate attrCert, X509Certificate tbvCert, PkixBuilderParameters pkixParams, IList tbvPath)
		{
			return null;
		}
	}
}
