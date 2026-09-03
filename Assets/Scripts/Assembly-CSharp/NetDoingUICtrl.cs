using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class NetDoingUICtrl : MediatorCtrlBase
{
	public GameObject window;

	public Transform RotatingParent;

	public Image Image_Rotate;

	public DxxText Text_Count;

	public DxxText Text_Code;

	public DxxText Text_Loading;

	public CanvasGroup mCanvasGroup;

	private Sequence seq_load;

	private Sequence seq_delay;

	private Sequence seq_close;

	private int loadingindex;

	private RectTransform t;

	private string m_sCode;

	private NetDoingProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected override void OnOpen()
	{
	}

	private void SetLoading(int index)
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
