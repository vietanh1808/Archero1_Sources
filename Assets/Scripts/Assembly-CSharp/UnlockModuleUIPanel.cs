using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class UnlockModuleUIPanel : MediatorCtrlBase
{
	public DxxText Text_title;

	public DxxText Text_name;

	public DxxText Text_desc;

	public DxxText Text_go;

	public DxxText Text_next;

	public DxxImage Image_icon;

	public GameObject goEffect;

	public ButtonCtrl Button_go;

	public ButtonCtrl Button_next;

	public RectTransform rectIcon;

	public RectTransform rectTitle;

	[SerializeField]
	private Vector2 oriAnchorPosTitle;

	[SerializeField]
	private Vector2 oriAnchorPosIcon;

	[SerializeField]
	private Vector2 shownAnchorPosTitle;

	[SerializeField]
	private Vector2 shownAnchorPosIcon;

	[SerializeField]
	private Vector3 oriScaleTitle;

	[SerializeField]
	private Vector3 oriScaleIcon;

	[SerializeField]
	private Vector3 shownScaleTitle;

	[SerializeField]
	private Vector3 shownScaleIcon;

	private float progress;

	private Vector3 curIconPos;

	private Vector3 curIconScale;

	private Vector3 targetPos;

	private Vector3 targetScale;

	private UnlockModuleData curModuleData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void GoToModule()
	{
	}

	private void TryShowNextModule()
	{
	}

	private void PlayTweenMoveIn()
	{
	}

	private void PlayTweenGoToModule()
	{
	}

	private void PlayTweenSwitchModule()
	{
	}

	private bool SetTweenTarget()
	{
		return false;
	}

	private void SetUI()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void AppendEnter(Sequence sequence)
	{
	}

	private void AppendMoveToTarget(Sequence sequence)
	{
	}

	private void AppendResetToOrigin(Sequence sequence)
	{
	}

	private void ResetToOrigin()
	{
	}

	private void AppendResetToCenter(Sequence sequence)
	{
	}

	private void AppendHideButton(Sequence sequence)
	{
	}

	private void AppendShowButton(Sequence sequence)
	{
	}
}
