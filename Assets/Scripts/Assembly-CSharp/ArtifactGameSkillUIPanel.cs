using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactGameSkillUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private Image artifactIcon;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private Image qualityFrame;

	[SerializeField]
	private Image skillIcon;

	[SerializeField]
	private DxxFitContentText skillDesc;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Transform skillStarParent;

	[SerializeField]
	private ArtifactGameSkillStar skillStar;

	private LocalSave.ArtifactGameSkillItemData gameSkillItemData;

	private LocalUnityObjctPool pool;

	private void InitPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStar()
	{
	}

	private void RefreshStatus()
	{
	}

	private void Esc()
	{
	}
}
