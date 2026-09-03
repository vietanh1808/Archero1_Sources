using UnityEngine;

public class WingPreviewUICtrl : MediatorCtrlBase
{
	public WingModelShowPart modelShowPart;

	public WingAttributePart attributePart;

	public ButtonCtrl switchBtn;

	public ButtonCtrl closeBtn;

	public DxxText titleText;

	public DxxText nameText;

	private LocalSave.WingOne wing;

	public DxxImage image_HeroBg;

	public DxxImage image_BgLight;

	public DxxImage image_banner;

	public ButtonCtrl upPreviewBtn;

	public DxxText upPreviewTex;

	public RectTransform rateTrans;

	private const string atlas = "newskinpreview";

	private const string skinBgPath = "heroskinbg_";

	private const string skinLightPath = "heroskinlight_";

	private const string skinBannerPath = "heroskinbanner_";

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshRate()
	{
	}

	public void ClosePanel()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnClickUpPreview()
	{
	}
}
