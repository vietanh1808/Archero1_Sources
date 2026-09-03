using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtractPanel : MonoBehaviour, IEquipRefinePanel
{
	[SerializeField]
	private ButtonCtrl btnExtract;

	[SerializeField]
	private GameObject goPreview;

	[SerializeField]
	private GameObject goEquipOneTemplate;

	[SerializeField]
	private RectTransform rtNormalRoot;

	[SerializeField]
	private RectTransform rtCoreRoot;

	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private DxxText txtTitleRandom;

	[SerializeField]
	private DxxText txtTitleNormal;

	[SerializeField]
	private DxxText txtBtnExtract;

	[SerializeField]
	private DxxText txtEmpty;

	[SerializeField]
	private EquipRefineCombineInfinity infinity;

	[SerializeField]
	private ScrollRect srCandidates;

	[SerializeField]
	private ScrollRect srCertain;

	[SerializeField]
	private ScrollRect srRandom;

	[SerializeField]
	private ButtonCtrl[] btnPoses;

	[SerializeField]
	private DxxImage[] btnBgs;

	[SerializeField]
	private Sprite[] btnBgSprites;

	private int curPos;

	private HashSet<ulong> selectedIds;

	private List<LocalSave.EquipOne> candidates;

	private Dictionary<int, int> scrolls;

	private LocalUnityObjctPool pool;

	private int gold;

	private const string EXTRACT_TAG = "[铭文熔炼]";

	private int configPos => 0;

	public void Init()
	{
	}

	private void UpdateCallback(int index, EquipRefineCombineOne item)
	{
	}

	private void OnItemClick(EquipRefineCombineOne one)
	{
	}

	private void OnExtractClick()
	{
	}

	public void Open(int arg)
	{
	}

	public void Close()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshPosFilter()
	{
	}

	private void RefreshItems()
	{
	}

	private void RefreshData()
	{
	}

	private int SortComparison(LocalSave.EquipOne a, LocalSave.EquipOne b)
	{
		return 0;
	}

	private void RefreshButton()
	{
	}

	private void RefreshRewards()
	{
	}

	public void OnLanguageChange()
	{
	}

	public int CurPos()
	{
		return 0;
	}

	private int GetConfigPos(int index)
	{
		return 0;
	}
}
