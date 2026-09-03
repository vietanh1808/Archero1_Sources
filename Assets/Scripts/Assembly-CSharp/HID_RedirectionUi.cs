using System;
using HabbySdk.HabbyId;
using UnityEngine;
using UnityEngine.UI;

public class HID_RedirectionUi : HIDUIBase
{
	[NonSerialized]
	public bool isTooMany;

	private bool receive;

	private string receiveEmail;

	private string emailCode;

	private string playerEmail;

	public Button cancelButton;

	public Button sendButton;

	public LocalizationText sendText;

	public Text codeText;

	public Button copyCodeButton;

	public Button refreshButton;

	public Text receiveEmailText;

	public Button copyReceiveEmailButton;

	private const float RefreshMaxTime = 60f;

	private float refreshTime;

	public GameObject refreshTimeObj;

	public Text refreshTimeText;

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

	private float delayTime;

	public CanvasGroup bgCG => null;

	public void SetData(string receiveEmail, string emailCode, string playerEmail, bool receive)
	{
	}

	private void Start()
	{
	}

	private void OnClickCancel()
	{
	}

	private void OnClickRefresh()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SuccessLoginCallback()
	{
	}

	private void Update()
	{
	}

	private void OnClickSend()
	{
	}

	private string EscapeUrl(string url)
	{
		return null;
	}

	public override void NormalShow()
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
