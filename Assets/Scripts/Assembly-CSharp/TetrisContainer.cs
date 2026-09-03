using System;
using System.Collections.Generic;
using Dxx.Util;
using NewPlay125;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TetrisContainer : UIBehaviour
{
	public const string RootName = "TetrisContainer";

	public const string GridRootName = "GridRoot";

	public const string TetrisArrangedRoot = "TetrisArrangedRoot";

	private LocalBackpackVO _LocalSave;

	private bool _justAdded;

	public int EditingUnitCount;

	public TetrisUnit CurEditingUnit;

	public TetrisCommon.PackEditMode curMode;

	[SerializeField]
	private Transform gridRoot;

	[SerializeField]
	private RectTransform unlockedGridsRoot;

	[SerializeField]
	private RectTransform unlockedRoot;

	[SerializeField]
	private TetrisUnit unlockedUnit;

	[SerializeField]
	private RectTransform bgRoot;

	[SerializeField]
	private DustbinCtrl _dustbinCtrl;

	public RectTransform ArrangedRoot;

	public RectTransform QueuedRoot;

	public RectTransform QueuedOriginRoot;

	public RectTransform UnlocekGridsRoot;

	private List<GameObject> upgradeFxList;

	private GraphicRaycaster _rayCaster;

	private RectTransform rect;

	[SerializeField]
	private int RowCount;

	[SerializeField]
	private int ColumCount;

	[SerializeField]
	private GridLayoutGroup grid;

	public TetrisPackItem[,] PackGridsLayout;

	public TetrisPackItem[,] UnlockedPackGridsLayout;

	public Dictionary<int, TetrisUnit> InPackUnitsDict;

	public Dictionary<int, TetrisUnit> InPackEditingUnitsDict;

	private List<TetrisUnit> underUnitsList;

	private List<TetrisUnitConfig> randomUnits;

	private bool isRandomUnitsCalled;

	private List<(int, int)> refreshCountList;

	private SequencePool _sequencePool;

	public GraphicRaycaster Raycaster => null;

	public RectTransform RectSelf => null;

	public List<int> WeaponsIn => null;

	public List<TetrisUnit> UnderUnitsList => null;

	public bool DustbinOpen => false;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	public void Init()
	{
	}

	public void InitBackPack()
	{
	}

	public void InitBackPack(bool isFirst)
	{
	}

	public bool IsPackUnitNearby(List<TetrisPackItem> destPack, int instId)
	{
		return false;
	}

	public bool CanUnlockPackLiftUp(int curRowNum, int curColumnNum)
	{
		return false;
	}

	public void SwitchToPackEditMode()
	{
	}

	public void SwitchToWeaponArrangeMode()
	{
	}

	private void RegeneratePack()
	{
	}

	public void RandomUnits(int times = 0)
	{
	}

	private TetrisUnitConfig RandomSingleItem(int waveCount)
	{
		return null;
	}

	public void SpawnNewUnits(List<TetrisUnitConfig> unitList)
	{
	}

	private void SpawnWeaponsFromSave(Dictionary<int, TetrisUnit.CoreData> unitDatasDict)
	{
	}

	public TetrisUnit AssembleUnitByConfig(TetrisUnitConfig config, TetrisUnit.CoreData data = null)
	{
		return null;
	}

	private int GetTetrisNewUid()
	{
		return 0;
	}

	public void ClearUnlockedRoot()
	{
	}

	public void RePositionAllWeapons(int offsetX, int offsetY)
	{
	}

	private GameObject AddChildByName(string rootName, Transform parent)
	{
		return null;
	}

	private void DestroyAllChildren(Transform destTransform, bool onlyActive = false, GameObject except = null)
	{
	}

	public void AddPackUnit(TetrisUnit unit)
	{
	}

	public void OccupyPackGrids(int rowIndex, int columIndex, bool[,] grids, int occupyId)
	{
	}

	public void MoveDownOverlapWeapons(List<TetrisPackItem> checkList)
	{
	}

	public void RemoveWeaponAfterUpgrade(int instanceId)
	{
	}

	public void AddWeaponList(int id)
	{
	}

	public void RemoveWeaponList(int id)
	{
	}

	public void ReleasePackGrids(int rowIndex, int columIndex, bool[,] grids)
	{
	}

	public void ReleaseWeaponGrids(int rowIndex, int columIndex, bool[,] grids, TetrisUnit unit)
	{
	}

	public void ReleaseUnlockedGrids(bool[,] grids)
	{
	}

	public int OccupyUnlockedPackGrids(int rowIndex, int columIndex, bool[,] grids, int occupyId, TetrisUnit unit, bool addData = true)
	{
		return 0;
	}

	private int ChangeGridsIds(int rowIndex, int columIndex, bool[,] grids, int changeId, TetrisPackItem[,] destGrids, int[,] gridsForSave)
	{
		return 0;
	}

	public void CombineAllUnlockedGridIds()
	{
	}

	public void RegenerateUnlockedPackArr(int row, int column)
	{
	}

	public void AddUnderUnitsList(TetrisUnit unit)
	{
	}

	public void RemoveFromUnderUnitsList(TetrisUnit unit)
	{
	}

	public Vector3 GetPackTopLeftGridWorldPos()
	{
		return default;
	}

	public Vector3 GetBottomFirstUnitPos()
	{
		return default;
	}

	public bool GetCanCombineUnits(out Vector3 pos1, out Vector3 pos2)
	{
		pos1 = default;
		pos2 = default;
		return false;
	}

	public bool GetInPackPursePositions(ref List<Vector3> list)
	{
		return false;
	}

	public void PlayUpgradeFx(Transform rect)
	{
	}

	public void DustbinSwallow(TetrisUnit tetrisUnit, List<Vector3> posList = null)
	{
	}

	public void DustbinSwallow(TetrisUnitConfig config, List<Vector3> posList = null)
	{
	}

	public void DustbinSwallow(int addCoin, List<Vector3> posList = null)
	{
	}

	public void CalDustbinPos()
	{
	}

	public void DustbinRemainings(Action callback)
	{
	}
}
