using UnityEngine;

public class SailingShipPartItemSourceData
{
	public int partID;

	public int level;

	public int star;

	public int skinID;

	public SailingShipPartPosType posType;

	public Vector2 posInShip;

	public Vector2 Pivot;

	public Sprite icon;

	public int slotID;

	public bool IsMonster;

	public static SailingShipPartItemSourceData Create(int partID, int level, int skinID, Vector2 pos = default(Vector2), Sprite partIcon = null, Vector2 pivot = default(Vector2), int slotID = 0, bool isMonster = false)
	{
		return null;
	}

	public void SyncPosType(SailingShipPartPosType pType)
	{
	}

	public void SetSkinId(int id)
	{
	}

	public void SetLevel(int lv)
	{
	}

	public void SetPos(Vector2 pos)
	{
	}

	public void SetPivot(Vector2 pivot)
	{
	}
}
