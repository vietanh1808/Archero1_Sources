using UnityEngine;

public class TotemSlotItemData
{
	private TotemSlotConfigData sourceData { get; set; }

	private int Angle => 0;

	public int ID => 0;

	public TotemSlotType CircleType => TotemSlotType.None;

	public TotemType TotemType => TotemType.None;

	public int UnlockChapter => 0;

	public Sprite Icon => null;

	public string SlotName => null;

	public bool IsUnlocked => false;

	public static TotemSlotItemData Create(TotemSlotConfigData sourceData)
	{
		return null;
	}

	public Vector2 GetPos(float radius)
	{
		return default;
	}
}
