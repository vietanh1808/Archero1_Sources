using System.Collections.Generic;
using UnityEngine;

public class BattleBossHPCtrl : MonoBehaviour
{
	public class BossHPSkillVO
	{
		public int skillId;

		public int percentage;

		public bool isUsed;

		public BossHPSkillItem item;
	}

	private const string BossAnimationName = "BossHPShow";

	public GameObject BossHPSkillItemPrefab;

	public GameObject child;

	public RectTransform BossHP_FG;

	public RectTransform BossHP_FGReduce;

	public RectTransform BossHP_FGReduce1;

	public Animation Ani_Boss;

	private BattleUIBossHPCtrl mBossHPCtrl;

	private int BossHPWidth;

	private bool bShow;

	private const float FULL_PERCENTAGE = 100f;

	private const float PERCENTAGE_UNIT = 25f;

	private SortedDictionary<int, BossHPSkillVO> dict;

	private List<BossHPSkillItem> skillItemList;

	private LocalUnityObjctPool mPool;

	public float CurBossHPPercent { get; set; }

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void Show(bool show)
	{
	}

	public void UpdateBossHP(float value)
	{
	}

	public bool IsShow()
	{
		return false;
	}

	private void initDict()
	{
	}

	public void CheckIfSkillUsed(float curHpPercent)
	{
	}

	private void initObjectPool()
	{
	}

	public void UpdateSkillItem(BossHPSkillVO vo)
	{
	}
}
