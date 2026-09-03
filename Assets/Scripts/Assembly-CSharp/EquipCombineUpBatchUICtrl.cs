using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class EquipCombineUpBatchUICtrl : MediatorCtrlBase
{
	public DxxText txtSuccess;

	public RectTransform iconParent;

	public TapToCloseCtrl tapToClose;

	public ButtonCtrl shareBtn;

	public FBShareBtnCtrl fbShareBtn;

	private EquipCombineUpBatchProxy.Transfer transfer;

	private List<EquipOneCtrl> resultList;

	private LocalUnityObjctPool mPool;

	private SequencePool seqPool;

	public RectTransform startPos;

	private Sequence _sequence;

	[SerializeField]
	private ParticleSystemCallbackInvoker psInvoker;

	private const int width = 160;

	private const int height = 160;

	private const int LineCount = 4;

	public Button touchScreenButton;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void GetIntervalAndAudio(Sequence sequence, int totalIndex, int rows)
	{
	}

	private void GetTween(RectTransform one, float startx, int index, int totalHeight)
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnShareButtonClick()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void OnButtonTouchScreen()
	{
	}

	private int Comparison(LocalSave.EquipOne a, LocalSave.EquipOne b)
	{
		return 0;
	}
}
