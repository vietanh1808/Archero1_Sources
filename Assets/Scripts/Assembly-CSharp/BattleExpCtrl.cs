using Dxx.Util;
using UnityEngine;

public class BattleExpCtrl : MonoBehaviour
{
	private const string ExpAnimationName = "HeroExpShow";

	private const string ExpScaleName = "HeroExpScale";

	public DxxText Text_Level;

	public Animation Ani_Exp;

	public RectTransform Exp_Add;

	public RectTransform Exp_Add1;

	public RectTransform Exp_BG;

	public RectTransform Exp_FG;

	private RectTransform rectTransform;

	private int ExpWidth;

	private int ExpBGWidth;

	private BattleUIBossHPCtrl mBossHPCtrl;

	private ActionUpdateCtrl mActionUpdateCtrl;

	private bool bDropExp;

	private SequencePool mSequencePool;

	private bool bShow;

	private int level;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void SetFringe()
	{
	}

	public void SetLevel(int level)
	{
	}

	public int GetLevel()
	{
		return 0;
	}

	private void set_progress(float value)
	{
	}

	public void ExpUP(ProgressAniManager vo)
	{
	}

	private void update_ui(ProgressAniManager.ProgressTransfer data)
	{
	}

	public void SetDropExp(bool drop)
	{
	}

	public void Show(bool show)
	{
	}
}
