using System.Collections.Generic;
using Newtonsoft.Json;

public class NewPlay127DiffItemData
{
	public int id;

	public int addition;

	[JsonProperty("data")]
	public List<List<int>> reward;
}
