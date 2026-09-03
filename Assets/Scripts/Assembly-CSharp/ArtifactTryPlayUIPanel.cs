using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactTryPlayUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public GameObject[] RatityObj;

	public DxxText Text_Name;

	public HeroPropInfoCtrl ATKItem;

	public HeroPropInfoCtrl HPItem;

	public DxxText Text_AttrTitle;

	public DxxText Text_TryPlay;

	public TryPlayAttrItem attrItem;

	public TryPlayStarItem starItem;

	public RectTransform starParent;

	public RectTransform attParent;

	public ButtonCtrl Button_TryPlay;

	public ScrollRect scroll;

	private LocalUnityObjctPool _pool;

	public ArtifactModelShow modelShow;

	private List<LocalSave.ArtifactOne> _artifactList;

	private LocalSave.ArtifactOne _crtArtiOne;

	private List<TryPlayAttrItem> _attrList;

	private List<Artifact_UpStar> _allConfig;

	private int _artId;

	private int _selectIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ScrollAt()
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

	private void FreshStar()
	{
	}

	private void FreshTopInfo()
	{
	}

	private void FreshSkillList()
	{
	}

	private string GetSkillDesc(LocalSave.ArtifactOne aOne)
	{
		return null;
	}

	private void OnBtnSelectClicked(int star)
	{
	}

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}

	private void OnBtnTryPlayClick()
	{
	}
}
