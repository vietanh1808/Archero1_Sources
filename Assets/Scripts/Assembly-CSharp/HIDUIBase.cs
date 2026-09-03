using HabbySdk.HabbyId;
using UnityEngine;

public class HIDUIBase : MonoBehaviour
{
	public const float OneFrameSecond = 0.03333333f;

	protected ProcessType type;

	private CanvasGroup _canvasGroup;

	public bool isOpening;

	private eHIDUI eHidui;

	protected HIDUIManager uiManager;

	public RectTransform rectTransform => null;

	public CanvasGroup canvasGroup => null;

	public HID_AnimHolder H => null;

	public HIDUIBase SetState(ProcessType type)
	{
		return null;
	}

	protected virtual void OnStateSet(ProcessType type)
	{
	}

	public void Init(eHIDUI eHidui, HIDUIManager hiduiManager)
	{
	}

	public virtual void NormalShow()
	{
	}

	public virtual void SelfCancelHide()
	{
	}

	public virtual void NormalHide()
	{
	}

	public virtual void NextCancelCauseShow()
	{
	}

	public virtual void ForceHide()
	{
	}

	protected void OpenTransparentMask()
	{
	}

	protected void HideTransparentMask()
	{
	}
}
