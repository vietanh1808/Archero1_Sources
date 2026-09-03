using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class LayerBoxUICtrl : MediatorCtrlBase
{
	private const string Ani_Info_Show = "Info_Show";

	private const string Ani_Info_Hide = "Info_Hide";

	public RectTransform window;

	public DxxText Text_Title;

	public DxxText Text_RewardsContent;

	public ButtonCtrl Button_Close;

	public ScrollIntLayerBoxCtrl mScrollInt;

	public Transform mScrollChild;

	public GameObject GoodsParent;

	public GameObject copyBox;

	public GameObject copyReward;

	public DxxText Text_Condition;

	public DxxText Text_Rewards;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public DxxText Text_Target;

	public DxxText Text_Got;

	public DxxText Text_Tips;

	private int showCount;

	private int count;

	private float allWidth;

	private float itemWidth;

	private float offsetx;

	private float lastscrollpos;

	private float lastspeed;

	private int mCurrentIndex;

	private int send_stage;

	private int send_layer;

	private List<LayerRewardOneCtrl> mRewards;

	private List<Box_ChapterBox> mDataList;

	private LayerBoxOneCtrl mChoose;

	private LocalUnityObjctPool mRewardPool;

	private int currentid;

	private bool bFirst;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateOne(int index, LayerBoxOneCtrl one)
	{
	}

	private void UpdateSize(int index, LayerBoxOneCtrl one)
	{
	}

	private void OnScrollEnd(int index, LayerBoxOneCtrl one)
	{
	}

	private void OnBeginDrag()
	{
	}

	private void SendLayer(int id)
	{
	}

	private void UnparsedData(List<Drop_DropModel.DropData> list)
	{
	}

	private void PlayRewards(List<Drop_DropModel.DropData> list)
	{
	}

	private Vector3 GetRewardPosition(int id)
	{
		return default;
	}

	private void UpdateReward()
	{
	}

	private void UpdateUI()
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
}
