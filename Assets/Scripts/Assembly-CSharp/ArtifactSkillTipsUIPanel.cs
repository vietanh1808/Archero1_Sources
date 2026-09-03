using PureMVC.Interfaces;
using UnityEngine;

public class ArtifactSkillTipsUIPanel : MediatorCtrlBase
{
	public class SkillInfoData
	{
		public int skillId;

		public Vector3 pos;
	}

	public GameObject Arrow;

	public RectTransform Content;

	public DxxText Text_Title;

	public DxxText Text_Desc;

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

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}
}
