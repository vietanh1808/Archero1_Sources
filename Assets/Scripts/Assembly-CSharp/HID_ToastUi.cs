using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HID_ToastUi : HIDUIBase
{
	public RectTransform defaultPos;

	public CanvasGroup redGroup;

	public Text redText;

	public CanvasGroup greenGroup;

	public Text greenText;

	private Sequence sequence;

	private void Start()
	{
	}

	public void SetData(string desc, bool greenToast = true)
	{
	}
}
