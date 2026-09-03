using UnityEngine;

public class HeadAndFrameInfoUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtAtt;

	[SerializeField]
	private PropOneEquip propOne;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnMask;

	[SerializeField]
	private PVPHeadAttItem[] attItems;

	[SerializeField]
	private GameObject go_att;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitFrame(HeadAndFrameInfoProxy.Transfer data)
	{
	}

	private void InitHead(HeadAndFrameInfoProxy.Transfer data)
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
