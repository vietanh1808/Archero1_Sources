using System.Collections.Generic;
using UnityEngine;

public class MeadowBattleMonsterInfo
{
	public enum AttackAreaEnum
	{
		Front_Rectangle = 1,
		Front_Triangle = 2,
		Bounds = 3,
		Cross = 4,
		Diagnoal_Cross = 5
	}

	public enum BodyAreaGrids
	{
		Single_1_Grid = 1,
		Horizontal_2_Grids = 2,
		Square_4_Grids = 4
	}

	public class MonsterLocationInfo
	{
		private Vector2Int _anchorGrid;

		public BodyAreaGrids BodyAreaEnum { get; private set; }

		public Vector2Int AnchorGrid
		{
			get
			{
				return default;
			}
			private set
			{
			}
		}

		public int AnchorGridX { get; set; }

		public int AnchorGridY { get; set; }

		public Vector3 AnchorPos => default;

		public Vector3 WorldPos => default;

		public Vector2Int BodyAreaInfo => default;

		public List<Vector2Int> CornerGrids => null;

		public List<Vector2Int> BodyAreaGridList => null;

		public MonsterLocationInfo(BodyAreaGrids _bodyAreaEnum, Vector2Int _anchorGrid)
		{
		}

		public void OnDeInit()
		{
		}

		public Vector3 GetAnchorPos(Vector3 pos)
		{
			return default;
		}

		public void UpdateAnchorGridByPos(Vector3 entityPos)
		{
		}

		public void UpdateAnchorGrid(Vector2Int _anchorGrid)
		{
		}

		public List<Vector2Int> GetBodyAreaGridsByAnchorGrid(Vector2Int _anchorGrid)
		{
			return null;
		}
	}

	public int CharID { get; private set; }

	public MonsterLocationInfo LocationInfo { get; private set; }

	public MeadowBattleMonsterInfo(int _charID, MonsterLocationInfo _locationInfo)
	{
	}
}
