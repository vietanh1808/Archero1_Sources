using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Pkix
{
	public class PkixNameConstraintValidator
	{
		private ISet excludedSubtreesDN;

		private ISet excludedSubtreesDNS;

		private ISet excludedSubtreesEmail;

		private ISet excludedSubtreesURI;

		private ISet excludedSubtreesIP;

		private ISet permittedSubtreesDN;

		private ISet permittedSubtreesDNS;

		private ISet permittedSubtreesEmail;

		private ISet permittedSubtreesURI;

		private ISet permittedSubtreesIP;

		private static bool WithinDNSubtree(Asn1Sequence dns, Asn1Sequence subtree)
		{
			return false;
		}

		public void CheckPermittedDN(Asn1Sequence dns)
		{
		}

		public void CheckExcludedDN(Asn1Sequence dns)
		{
		}

		private void CheckPermittedDN(ISet permitted, Asn1Sequence dns)
		{
		}

		private void CheckExcludedDN(ISet excluded, Asn1Sequence dns)
		{
		}

		private ISet IntersectDN(ISet permitted, ISet dns)
		{
			return null;
		}

		private ISet UnionDN(ISet excluded, Asn1Sequence dn)
		{
			return null;
		}

		private ISet IntersectEmail(ISet permitted, ISet emails)
		{
			return null;
		}

		private ISet UnionEmail(ISet excluded, string email)
		{
			return null;
		}

		private ISet IntersectIP(ISet permitted, ISet ips)
		{
			return null;
		}

		private ISet UnionIP(ISet excluded, byte[] ip)
		{
			return null;
		}

		private ISet UnionIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
		{
			return null;
		}

		private ISet IntersectIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
		{
			return null;
		}

		private byte[] IpWithSubnetMask(byte[] ip, byte[] subnetMask)
		{
			return null;
		}

		private byte[][] ExtractIPsAndSubnetMasks(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
		{
			return null;
		}

		private byte[][] MinMaxIPs(byte[] ip1, byte[] subnetmask1, byte[] ip2, byte[] subnetmask2)
		{
			return null;
		}

		private void CheckPermittedEmail(ISet permitted, string email)
		{
		}

		private void CheckExcludedEmail(ISet excluded, string email)
		{
		}

		private void CheckPermittedIP(ISet permitted, byte[] ip)
		{
		}

		private void checkExcludedIP(ISet excluded, byte[] ip)
		{
		}

		private bool IsIPConstrained(byte[] ip, byte[] constraint)
		{
			return false;
		}

		private bool EmailIsConstrained(string email, string constraint)
		{
			return false;
		}

		private bool WithinDomain(string testDomain, string domain)
		{
			return false;
		}

		private void CheckPermittedDNS(ISet permitted, string dns)
		{
		}

		private void checkExcludedDNS(ISet excluded, string dns)
		{
		}

		private void unionEmail(string email1, string email2, ISet union)
		{
		}

		private void unionURI(string email1, string email2, ISet union)
		{
		}

		private ISet intersectDNS(ISet permitted, ISet dnss)
		{
			return null;
		}

		protected ISet unionDNS(ISet excluded, string dns)
		{
			return null;
		}

		private void intersectEmail(string email1, string email2, ISet intersect)
		{
		}

		private void checkExcludedURI(ISet excluded, string uri)
		{
		}

		private ISet intersectURI(ISet permitted, ISet uris)
		{
			return null;
		}

		private ISet unionURI(ISet excluded, string uri)
		{
			return null;
		}

		private void intersectURI(string email1, string email2, ISet intersect)
		{
		}

		private void CheckPermittedURI(ISet permitted, string uri)
		{
		}

		private bool IsUriConstrained(string uri, string constraint)
		{
			return false;
		}

		private static string ExtractHostFromURL(string url)
		{
			return null;
		}

		public void checkPermitted(GeneralName name)
		{
		}

		public void checkExcluded(GeneralName name)
		{
		}

		public void IntersectPermittedSubtree(Asn1Sequence permitted)
		{
		}

		private string ExtractNameAsString(GeneralName name)
		{
			return null;
		}

		public void IntersectEmptyPermittedSubtree(int nameType)
		{
		}

		public void AddExcludedSubtree(GeneralSubtree subtree)
		{
		}

		private static byte[] Max(byte[] ip1, byte[] ip2)
		{
			return null;
		}

		private static byte[] Min(byte[] ip1, byte[] ip2)
		{
			return null;
		}

		private static int CompareTo(byte[] ip1, byte[] ip2)
		{
			return 0;
		}

		private static byte[] Or(byte[] ip1, byte[] ip2)
		{
			return null;
		}

		[Obsolete("Use GetHashCode instead")]
		public int HashCode()
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private int HashCollection(ICollection coll)
		{
			return 0;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		private bool CollectionsAreEqual(ICollection coll1, ICollection coll2)
		{
			return false;
		}

		private bool SpecialEquals(object o1, object o2)
		{
			return false;
		}

		private string StringifyIP(byte[] ip)
		{
			return null;
		}

		private string StringifyIPCollection(ISet ips)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
