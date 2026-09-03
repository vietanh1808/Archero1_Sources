using UnityEngine;

public class SeasonChapterUsersUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText m_textTitle;

	[SerializeField]
	private ButtonCtrl m_btnClose;

	[SerializeField]
	private LoopScrollView m_scrollview;

	[SerializeField]
	private SeasonChapterUserItemCtrl CopyOne;

	private LocalUnityObjctPool ItemPool;

	private SeasonChapterUsersProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnCreateItem(int index, RectTransform rt)
	{
	}

	private void OnClickItem(object item)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
