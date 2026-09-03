using Newtonsoft.Json;

namespace Activity.Lattice
{
	public class LatticeRewardLevelConfig
	{
		[JsonProperty("ID")]
		public int Id;

		[JsonProperty("Items")]
		public LatticeLayerConfig[] LayerConfigs;
	}
}
