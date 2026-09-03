using System.Collections.Generic;
using Array2DEditor;
using NewPlay125;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TetrisUnit : UIBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public class CoreData
	{
		public int SelfUid;

		public int minRowIndex;

		public int minColumIndex;

		public int configId;

		public CoreData Clone()
		{
			return null;
		}
	}

	private const string sGridRoot = "GridRoot";

	private const string sImage = "Image";

	public TetrisUnitConfig config;

	private LocalBackpackVO _LocalSave;

	[FormerlySerializedAs("MyUnityType")]
	public TetrisCommon.UnitType myUnitType;

	public TetrisCommon.WeaponUnitType WeaponType;

	[SerializeField]
	private GameObject gridUnitInstance;

	[SerializeField]
	private GameObject packGridUnitInstance;

	[SerializeField]
	private TetrisContainer mainContainer;

	[SerializeField]
	private GraphicRaycaster _rayCaster;

	[SerializeField]
	private GridLayoutGroup uiGrid;

	[SerializeField]
	public DxxImage weaponImage;

	public TetrisItem[] allItemsArr;

	public TetrisPackItem[] allPackItemArr;

	private List<TetrisPackItem> chekingPackItemList;

	[SerializeField]
	private Array2DBool UnitArrange;

	private bool[,] unitLayoutArray;

	public CoreData Data;

	private float checkInterval;

	private float preCheckTime;

	private float moveToQueuedTime;

	private float moveToArrangedTime;

	private float weaponRotateAngle;

	private float arrangedPosX;

	private float arrangedPosY;

	private bool canUnitDeploy;

	private bool canUnitCombine;

	private bool canUnderWeaponCombine;

	private Transform toCombineUnit;

	private RectTransform rect;

	private RectTransform curParent;

	private Vector3 delta;

	public List<TetrisPackItem> ChekingPackItemList => null;

	public RectTransform RectSelf => null;

	protected override void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void InitUnit(TetrisUnitConfig initConfig)
	{
	}

	private void CheckCanDeploy()
	{
	}

	public void RePositionByOffset(int rowOffset, int columOffset)
	{
	}

	public void CaculatePosition(int rowIndex, int columeIndex)
	{
	}

	public void OnUnitLiftedUp()
	{
	}

	private bool CanUnitLiftedUp()
	{
		return false;
	}

	public void OnUnitPutDown()
	{
	}

	public void MoveToArrangedPos(bool needTween = true)
	{
	}

	public void MoveToPackOriginPos()
	{
	}

	public void MoveToQueuedPos(bool needRelease = false)
	{
	}

	private void ResizeQueueLayout()
	{
	}

	private void RotateOrResetWeapon(bool rotate)
	{
	}

	public void SetContainer(TetrisContainer container)
	{
	}

	private void InitRayCaster()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void SetDraggedPosition(PointerEventData eventData)
	{
	}

	public void GeneralWeaponUnit()
	{
	}

	public void GeneralPackUnit()
	{
	}

	public void InitPackItemArr()
	{
	}

	public void SetUnitMode(TetrisCommon.PackEditMode mode)
	{
	}

	public void CombineUnlockedGrids(int offsetX, int offsetY, bool[,] newArr = null, int[,] idNewArr = null)
	{
	}

	public void GenUnlockedGridsFromSave(int[,] newIdArr, int[,] packArr, int rowIndex, int columnIndex)
	{
	}

	private void GenerateUnit(TetrisCommon.UnitType type, bool[,] newArr = null, int[,] newIdArr = null)
	{
	}

	private void AddCoin(int newId)
	{
	}

	private void UpGradeUnderPack()
	{
	}

	private void Upgrade()
	{
	}

	private GameObject CreatChildObj(Transform parent, string name)
	{
		return null;
	}

	private void DestroyAllChildren(Transform destTransform, bool onlyActive = false)
	{
	}

	public void SetRectTopLeft(RectTransform trans)
	{
	}

	public void SetRectCenter(RectTransform trans)
	{
	}
}
