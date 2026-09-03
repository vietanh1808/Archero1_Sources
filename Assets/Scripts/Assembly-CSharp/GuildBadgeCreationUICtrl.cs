using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuildBadgeCreationUICtrl : MonoBehaviour
{
	[SerializeField]
	private GameObject goBadge;

	[SerializeField]
	private GameObject goTags;

	[SerializeField]
	private GameObject badgeItem;

	[SerializeField]
	private GameObject tagItem;

	[SerializeField]
	private Transform badgeFillRoot;

	[SerializeField]
	private Transform badgeFrameRoot;

	[SerializeField]
	private RectTransform tagRoot;

	[SerializeField]
	private GuildBadgeItem _guildBadgeItem;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtBadgeTitle;

	[SerializeField]
	private DxxText txtBadgeInfo;

	[SerializeField]
	private DxxText txtTagTitle;

	[SerializeField]
	private DxxText txtTagInfo;

	[SerializeField]
	private DxxText txtBtnSaveBadge;

	[SerializeField]
	private DxxText txtBtnSaveTags;

	[SerializeField]
	private DxxText txtTagCount;

	[SerializeField]
	private DxxText txtFrameTitle;

	[SerializeField]
	private DxxText txtPicTitle;

	[SerializeField]
	private DxxText[] txtIndices;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnSaveBadge;

	[SerializeField]
	private ButtonCtrl btnSaveTags;

	[SerializeField]
	private ButtonCtrl btnFillLeft;

	[SerializeField]
	private ButtonCtrl btnFillRight;

	[SerializeField]
	private ButtonCtrl btnFrameLeft;

	[SerializeField]
	private ButtonCtrl btnFrameRight;

	public Action<int[], int> setTagsCallback;

	public Action<GuildBadgeData, int> setBadgeCallback;

	private int[] badgeIndex;

	private int mode;

	private List<int> tagIds;

	private List<int> all;

	private LocalUnityObjctPool pool;

	[SerializeField]
	private EndDragHandler[] endDragHandlers;

	[SerializeField]
	private ScrollRect[] scrollRects;

	[SerializeField]
	private HorizontalLayoutGroup[] layoutGroups;

	[SerializeField]
	private float cellSize;

	private const int FRAME = 0;

	private const int FILL = 1;

	private const int REQUIRED_TAG_COUNT = 3;

	private int badgeChangeTimes;

	private int tagChangeTimes;

	private static List<int> _allBadgeFill;

	private static List<int> _allBadgeFrame;

	private static List<int> _allTags;

	public static int DefaultBadgeFillId => 0;

	public static int RandomBadgeFillId => 0;

	public static int DefaultBadgeFrameId => 0;

	public static int RandomBadgeFrameId => 0;

	public static List<int> AllBadgeFillIds => null;

	public static List<int> AllBadgeFrameIds => null;

	public static List<int> AllTagIds => null;

	protected void Awake()
	{
	}

	public void Open(int fillId = 0, int frameId = 0, List<int> tagIds = null)
	{
	}

	public void Close()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void android_escape()
	{
	}

	private void RegisterButtons()
	{
	}

	private void MoveToIndex(int index, int target)
	{
	}

	private void SetUI()
	{
	}

	private void SetTagsCreator()
	{
	}

	private static int GetBadgeConfigIdByIndex(int index, bool isFill)
	{
		return 0;
	}

	public static List<int> GetListByThousand(int thousand)
	{
		return null;
	}

	private void SetBadgeCreator()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void SetType(int mode)
	{
	}
}
