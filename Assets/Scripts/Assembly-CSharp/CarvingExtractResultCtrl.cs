using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class CarvingExtractResultCtrl : MediatorCtrlBase
{
	[SerializeField]
	private BoxOpenBoxAniCtrl boxCtrl;

	[SerializeField]
	private DxxText txtGot;

	[SerializeField]
	private RectTransform rtParent;

	[SerializeField]
	private TapToCloseCtrl tapToCloseCtrl;

	private LocalUnityObjctPool pool;

	[SerializeField]
	private GameObject equipOne;

	[SerializeField]
	private GameObject effectFireObj;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Button touchScreenButton;

	private CarvingExtractProxy.Transfer transfer;

	private SequencePool seqPool;

	private const int Width = 160;

	private const int Height = 200;

	private const int RowCount = 4;

	protected override void OnInit()
	{
	}

	private void OnCloseClick()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void InitUI()
	{
	}

	private void InitBox()
	{
	}

	private void ShowEquips()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
