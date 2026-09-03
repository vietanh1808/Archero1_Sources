using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class Act5thHuntingGameGuide : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private GameObject guideObj;

	[SerializeField]
	private CanvasGroup tipCanvas;

	[SerializeField]
	private RectTransform tipParentRect;

	[SerializeField]
	private RectTransform particleParentRect;

	[SerializeField]
	private RectTransform pointParentRect;

	[SerializeField]
	private RectTransform pointRect;

	[SerializeField]
	private ButtonCtrl guideBtn;

	[SerializeField]
	private FitContentText guideTip;

	[SerializeField]
	private GameObject topUIContent;

	[SerializeField]
	private RectTransform previewBtnRect;

	private SequencePool pool;

	private int guideIndex;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingEntityManager HuntingEntityManager => null;

	private Act5thHuntingBaseData HuntingBaseData => null;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void GameStar()
	{
	}

	public void GameEnd()
	{
	}

	private void CheckGuideKillPreviewStart()
	{
	}

	private void CheckGuideTipStart()
	{
	}

	private void ClickGuideBtn()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}
}
