using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Newtonsoft.Json;

[Serializable]
public class RuneItemData
{
	[JsonIgnore]
	public string attr;

	[JsonIgnore]
	private ObscuredFloat _value;

	[JsonIgnore]
	private ObscuredInt _id;

	public int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
