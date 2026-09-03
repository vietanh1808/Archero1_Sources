using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class EquipBreakDownController : MonoBehaviour
{
	public ButtonCtrl Button_Close;

	public DxxText Text_Guide;

	public GameObject copyitems;

	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public EquipCombineInfinity mInfinity;

	public ButtonCtrl Button_Combine;

	public DxxText Text_Combine;

	public GameObject mMaskparent;

	private int leftpadding;

	private int width;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private Vector2 scrollsize;

	private bool bLock;

	private EquipCombineOne mPlayOne;

	private LocalSave.EquipOne mChooseEquip;

	private LocalUnityObjctPool mPool;

	private MutiCachePool<EquipCombineOne> mCachePool;

	private List<LocalSave.EquipOne> mList;

	private List<EquipCombineOne> mItemList;

	private int[] choose;

	public GameObject popPanel;

	public Button selectButton;

	public Image arrowImage;

	public Image[] popFocusImage;

	public DxxText[] popQualityText;

	public Color color_chooseNormal;

	public Color color_chooseFocus;

	public GameObject breakContainer;

	public PropOneEquip breakItem;

	private Dictionary<int, ulong> breaks;

	private Dictionary<int, PropOneEquip> results;

	public DxxText selectText;

	public RectTransform middle;

	private LocalUnityObjctPool mEquipOnePool;

	public void OnInit(LocalUnityObjctPool pool)
	{
	}

	public void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateChildCallBack(int index, EquipCombineOne one)
	{
	}

	private void set_guide_info(int index)
	{
	}

	private void show_combine_button(bool value)
	{
	}

	private void update_scroll_height()
	{
	}

	private void OnClickOne(EquipCombineOne one)
	{
	}

	public void checkBreakButton()
	{
	}

	private void android_escape()
	{
	}

	public void OnClose()
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void onButtonPopPanel()
	{
	}

	public void onButtonSelect()
	{
	}

	public void onButtonChoose(int type)
	{
	}

	public void addBreakOne(int index, LocalSave.EquipOne equip)
	{
	}

	public void reduceBreakOne(int index, LocalSave.EquipOne equip)
	{
	}

	private PropOneEquip getPropOne(Drop_DropModel.DropData data)
	{
		return null;
	}

	private EquipCombineOne getCombineOne(int index)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
