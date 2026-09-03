using HabbyUtils.UI;
using UnityEngine;

public class HID_BGUi : HIDUIBase
{
	public ClickSmallButton closeButton;

	private Vector3? localPos;

	private bool isHome;

	public HID_UIFrameItem NormalShowMove;

	public HID_UIFrameItem NormalShowAlpha;

	public HID_UIFrameItem CloseShowMove;

	public HID_UIFrameItem ClsoeShowAlpha;

	private HID_UIFrameItem NormalHideMove;

	private HID_UIFrameItem NormalHideAlpha;

	private HID_UIFrameItem CloseHideMove;

	private HID_UIFrameItem ClsoeHideAlpha;

	private bool isLoginSuccess;

	private void Start()
	{
	}

	public void SpecialDemand()
	{
	}

	public override void NormalShow()
	{
	}

	public override void SelfCancelHide()
	{
	}

	public void HideAll(bool isLoginSuccess)
	{
	}
}
