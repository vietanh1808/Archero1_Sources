using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;

public class EquipRefineCombinePanel : MonoBehaviour, IEquipRefinePanel
{
	public struct Candidate
	{
		public int index;

		public int id;

		public int pos;

		public int slot;

		public int configType;

		public int configPos;

		public int attrLevel;

		public int rarity;
	}

	[SerializeField]
	private DxxText txtGuide;

	[SerializeField]
	private DxxText txtBtnCombine;

	[SerializeField]
	private DxxText txtNewSkill;

	[SerializeField]
	private DxxText txtNewAttr;

	[SerializeField]
	private DxxText txtEmpty;

	[SerializeField]
	private PropOneEquip propResult;

	[SerializeField]
	private PropOneEquip[] propMaterials;

	[SerializeField]
	private ScrollRectBase scrollRect;

	[SerializeField]
	private ButtonCtrl btnCombine;

	[SerializeField]
	private EquipRefineCombineInfinity infinity;

	[SerializeField]
	private GameObject goResultBg;

	[SerializeField]
	private GameObject[] goMaterialBgs;

	[SerializeField]
	private RectTransform[] goMatPreviewBgs;

	[SerializeField]
	private GameObject copyOne;

	[SerializeField]
	private GameObject goPropPreview;

	[SerializeField]
	private CarvingCombineAttr[] propItems;

	[SerializeField]
	private ButtonCtrl[] btnPoses;

	[SerializeField]
	private DxxImage[] btnBgs;

	[SerializeField]
	private Sprite[] btnBgSprites;

	private List<int> selectedIndices;

	private List<Candidate> allCandidates;

	private List<Candidate> filteredCandidates;

	private Dictionary<int, int> idToCount;

	private Dictionary<int, (int, int)> attrLevelToCount;

	private Dictionary<int, Dictionary<int, int>> rarityToQualityToCount;

	private HashSet<int> canCombine;

	private Equip_equip mainMaterialConfig;

	private Equip_equip result;

	private int curPos;

	private LocalUnityObjctPool mPool;

	private Dictionary<int, int> ramdomToCount;

	private int configPos => 0;

	private bool materialFull => false;

	private void Awake()
	{
	}

	private int GetConfigPos(int index)
	{
		return 0;
	}

	private void UpdateCallback(int index, EquipRefineCombineOne item)
	{
	}

	private void OnItemClick(EquipRefineCombineOne item)
	{
	}

	private void OnBtnCombineClick()
	{
	}

	private void SendCombineRequest()
	{
	}

	public void Init()
	{
	}

	public void Open(int arg)
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	public int CurPos()
	{
		return 0;
	}

	private void ClearSelection()
	{
	}

	private void RefreshAll(bool rebuildCache)
	{
	}

	private Func<Candidate, bool> GetCombineFilter()
	{
		return null;
	}

	private void RefreshCandidatesData(bool rebuildCache)
	{
	}

	private void RebuildCarvingsCache(IEnumerable<STCarvingItem> carvingsOfCurrentPos)
	{
	}

	private void RebuildCombinabilityCache(IEnumerable<STCarvingItem> carvings)
	{
	}

	private bool CalcCombinability(Equip_equip config)
	{
		return false;
	}

	private void ResetCarvingsCache()
	{
	}

	private bool CanCombine(int id)
	{
		return false;
	}

	private int Comparison(Candidate a, Candidate b)
	{
		return 0;
	}

	private void RefreshResultAndMaterials()
	{
	}

	private void RefreshGuide()
	{
	}

	private void RefreshPosFilter()
	{
	}
}
