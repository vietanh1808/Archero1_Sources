using System;
using UnityEngine;

[Serializable]
public class SLGTileVO
{
	public int Tile_X;

	public int Tile_Y;

	public int[] recordOccupyValue;

	public int needValue;

	[SerializeField]
	public CampID occupyCamp;

	public int bossBattleStage;

	public int[] bossMonsterOccupyValue;

	public int[] bossCampRank;

	public int[] bossCampScore;

	public int[] TownSkins;

	public void Clear()
	{
	}

	public SLGTileVO Clone()
	{
		return null;
	}
}
