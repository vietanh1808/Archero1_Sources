using Newtonsoft.Json;

namespace Activity.Lattice
{
	public class LatticeLayerConfig
	{
		[JsonProperty("id")]
		public int Id;

		[JsonProperty("MinLayers")]
		public int LayerMin;

		[JsonProperty("MaxLayers")]
		public int LayerMax;

		[JsonProperty("special_items")]
		public int[][] RewardsSpecial;

		[JsonProperty("normal_items")]
		public int[][] RewardsNormal;

		public int SpecialLayer;
	}
}
