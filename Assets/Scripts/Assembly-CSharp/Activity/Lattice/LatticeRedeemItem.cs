using Newtonsoft.Json;

namespace Activity.Lattice
{
	public class LatticeRedeemItem
	{
		[JsonProperty("ID")]
		public int Id;

		public int Count;

		public string Target;

		public string[] Need;
	}
}
