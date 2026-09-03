using Newtonsoft.Json;

namespace Activity.Lattice
{
	public class LatticeGiftPack
	{
		[JsonProperty("ID")]
		public int Id;

		[JsonProperty("Layer_Min")]
		public int LayerMin;

		[JsonProperty("Layer_Max")]
		public int LayerMax;

		public LatticeGiftPackItem[] Items;
	}
}
