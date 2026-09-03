using HabbySdk.HabbyId;
using HabbyUtils.UI;
using UnityEngine;

public class HID_VerifyUi : HIDUIBase
{
	public ButtonBase cancelButton;

	public ButtonBase confirmButton;

	public VerifyCodeTool VerifyCodeTool;

	public ButtonBase notReceiveButton;

	private string email;

	private bool receive;

	public LocalizationText toastText;

	private bool isFocused;

	private int lastLength;

	public HID_ContinueButton HidContinueButton;

	public CanvasGroup cancelButtonCG;

	public CanvasGroup conButtonCG;

	public CanvasGroup descTextCG;

	public CanvasGroup inputFieldCG;

	public CanvasGroup redIconCG;

	public CanvasGroup topIconCG;

	public CanvasGroup writeCircleCG;

	private Vector2? bgStartPosition;

	private Vector2? cancelButtonStartPosition;

	private Vector2? conButtonStartPosition;

	private Vector2? descTextStartPosition;

	private Vector2? inputFieldStartPosition;

	private Vector2? redIconStartPosition;

	private Vector2? topIconStartPosition;

	private bool isSuccessLogin;

	private float delayTime;

	public CanvasGroup bgCG => null;

	public void SetEmail(string email, bool receive)
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnClickNotReceive()
	{
	}

	private void OnCodeInputChanged(string arg0)
	{
	}

	private void OnClickConfirm()
	{
	}

	public override void NormalShow()
	{
	}

	public void SpecialNormalHide(bool isSuccess)
	{
	}

	public override void NormalHide()
	{
	}

	public override void NextCancelCauseShow()
	{
	}

	public override void SelfCancelHide()
	{
	}
}
