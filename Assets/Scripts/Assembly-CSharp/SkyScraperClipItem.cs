using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SkyScraperClipItem : ViewCell
{
	public ViewCell[] boxItem;

	public RectTransform clipRect;

	public RectTransform boxRect;

	public Transform rewardParent;

	public Image boxImg;

	public float deltaSize;

	private SkyScraperGameClipData itemData;

	private TimeLineContainer timeLine;

	private Tween tween;

	protected override void OnInit()
	{
	}

	protected override void OnRefresh()
	{
	}

	private void PlayClip(float downTime, float stayTime, float upTime, float starTime)
	{
	}

	private void RefreshUI()
	{
	}

	protected override void OnRecycle()
	{
	}
}
