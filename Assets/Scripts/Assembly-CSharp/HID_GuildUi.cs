using HabbySdk.HabbyId;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HID_GuildUi : HIDUIBase
{
	public Button guildNextButton;

	private Vector2 startPos;

	public LocalizationText descText;

	public LocalizationText buttonText;

	public GameObject icon;

	public VideoPlayer video;

	public HID_UIFrameItem NormalShowButtonMove;

	public HID_UIFrameItem NormalShowButtonAlpha;

	public HID_UIFrameItem NormalShowTextMove;

	public HID_UIFrameItem NormalShowTextAlpha;

	private Vector2? buttonStartPos;

	private Vector2? descTextStartPos;

	public HID_UIFrameItem ReversiHideButtonAlpha;

	public HID_UIFrameItem ReversiHideButtonMove;

	public HID_UIFrameItem ReversiHideTextAlpha;

	public HID_UIFrameItem ReversiHideTextMove;

	private CanvasGroup nextButtonGroup => null;

	private CanvasGroup descTextGroup => null;

	private void Start()
	{
	}

	protected override void OnStateSet(ProcessType type)
	{
	}

	private void PlayLogoAnim()
	{
	}

	private void DebugDumpRenderTexture()
	{
	}

	public override void NormalShow()
	{
	}

	public override void NormalHide()
	{
	}

	private void DelayHide()
	{
	}

	public override void NextCancelCauseShow()
	{
	}

	public override void SelfCancelHide()
	{
	}
}
