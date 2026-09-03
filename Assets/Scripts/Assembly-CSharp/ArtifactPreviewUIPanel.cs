using PureMVC.Interfaces;
using UnityEngine;

public class ArtifactPreviewUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public GameObject[] RatityObj;

	public DxxText Text_Name;

	public ArtifactStarShowItem starItem;

	public HeroPropInfoCtrl ATKItem;

	public HeroPropInfoCtrl HPItem;

	public DxxText Text_AttrTitle;

	public GameObject cpAttrItem;

	public RectTransform Content;

	public ButtonCtrl Button_View;

	public GameObject ViewIcon1;

	public GameObject ViewIcon2;

	public ArtifactModelShow modelShow;

	public ArtifactSkillIcon skillIcon;

	private LocalSave.ArtifactOne artiOne;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void initUI()
	{
	}

	private void freshTopInfo()
	{
	}

	private void freshSkillList()
	{
	}

	private void freshLeftButton()
	{
	}

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}

	private void onButtonView()
	{
	}
}
