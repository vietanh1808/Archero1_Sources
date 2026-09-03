using DG.Tweening;
using UnityEngine;

public class RefineStarCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxImage[] stars;

	[SerializeField]
	private DxxImage[] starsEffect;

	[SerializeField]
	private DxxImage starBreakthroughResult;

	[SerializeField]
	private DxxImage starUpgradeResultSingle;

	[SerializeField]
	private Sprite[] sprites;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private int curStar;

	private int curQuality;

	private int nextStar;

	private int nextQuality;

	[SerializeField]
	private int level;

	[SerializeField]
	private bool hintNext;

	[SerializeField]
	private GameObject goNormalRoot;

	[SerializeField]
	private GameObject goEffectRoot;

	[SerializeField]
	private GameObject goEffectSingleRoot;

	private bool isShowingNext;

	private Sequence seq;

	private Tween tween;

	public Sequence SetLevel(int level, bool hintNext, bool playBreakthrough = false)
	{
		return null;
	}

	private void SetCurrentStars()
	{
	}

	private void SwitchQualityPreview()
	{
	}

	private void PlayEffect()
	{
	}

	private int GetRealStar(int star)
	{
		return 0;
	}
}
