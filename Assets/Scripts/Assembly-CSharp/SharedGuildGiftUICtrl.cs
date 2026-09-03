using UnityEngine;

public class SharedGuildGiftUICtrl : MediatorCtrlBase
{
	private const string Tag = "SharedGuildGiftUICtrl";

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	[SerializeField]
	[Header("工会红包倒计时")]
	private DxxText Text_Cd;

	public DxxText Text_Content;

	public DxxText Text_RewardsTitle;

	public PropOneEquip CopyOne;

	public RectTransform Content;

	private SharedGuildGiftProxy.Transfer mTransfer;

	private LocalUnityObjctPool mPool;

	private float m_fTime;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected override void OnClose()
	{
	}
}
