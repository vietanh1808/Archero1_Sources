using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GemCombineEndCtrl : MediatorCtrlBase
{
	public DxxText Text_Name;

	public DxxText Text_Quality;

	public RectTransform iconparent;

	public GameObject successparent;

	public GameObject attributeparent;

	public DxxText Text_Success;

	public GameObject effect_thunder;

	public GameObject effect_rotate;

	public GameObject effect_bomb;

	public Transform attparent;

	public GameObject copyitems;

	public GameObject copyatt;

	public TapToCloseCtrl mCloseCtrl;

	public ButtonCtrl mShareBtn;

	public FBShareBtnCtrl mShareCtrl;

	private LocalUnityObjctPool mPool;

	private GemCombineEndProxy.Transfer mTransfer;

	private List<GemCombineEndAttrCtrl> mAttList;

	private AnimationCurve curve_move;

	private AnimationCurve curve_sin;

	private GameObject[] effectcombinings;

	private UISortOrder effectend;

	private UISortOrder effectlight;

	private Dictionary<int, UISortOrder> effect_fronts;

	public Button touchScreenButton;

	public GameObject effectFireObj;

	private LocalSave.EquipOne endGem;

	private List<LocalSave.EquipOne> basicGemList;

	public GameObject singleMode;

	public GameObject batchMode;

	public RectTransform batchRect;

	public GameObject cpRetItem;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initBatch()
	{
	}

	private void InitUI()
	{
	}

	public void show_effect_front(bool value)
	{
	}

	private void show_effect_combining(bool value, EquipOneCtrl left = null, EquipOneCtrl right = null, EquipOneCtrl middle = null)
	{
	}

	private void show_effect_end(bool value, EquipOneCtrl middle)
	{
	}

	private void show_effect_light(bool value, EquipOneCtrl middle)
	{
	}

	private void update_canvas(GameObject o, bool add)
	{
	}

	private void android_escape()
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

	public void OnButtonTouchScrren()
	{
	}
}
