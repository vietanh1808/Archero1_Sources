using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayActivityOneCtrl : MonoBehaviour
{
	public enum GamePlayActivityStatus
	{
		TempOpen = 0,
		TempClose = 1,
		AlwaysOpen = 2,
		AlwaysClose = 3,
		None = 4
	}

	protected GamePlayActivityStatus mStatus;

	public float Heigth;

	public int Type;

	public GameObject TitleNameEnd;

	public GameObject TitleNameAlone;

	public DxxText textNameAlone;

	public DxxText textEndTime;

	public DxxText textRestTime;

	public DxxText textStartTime;

	public DxxText textTitle;

	public DxxText textDesc;

	public GameObject maskObject;

	public GameObject maskBg;

	[SerializeField]
	private GameObject EndTimeContainer;

	[SerializeField]
	private ButtonCtrl EndTimeBtn;

	[SerializeField]
	private DxxText EndTimeBtnText;

	[SerializeField]
	private GameObject EndTimeContent;

	[SerializeField]
	private DxxText EndTimeText;

	public PropOneEquip copyProp;

	public DxxText textReward;

	public GridLayoutGroup rewardParent;

	private List<PropOneEquip> rewardList;

	public LocalSave.GamePlayActivityOneData mData;

	protected Daily_DailyType tableData;

	[SerializeField]
	private ButtonCtrl btnInfo;

	protected bool IsEndTimeOpen => false;

	protected virtual string EndTimeKey => null;

	protected virtual long LastTime => 0L;

	public virtual void SetData(LocalSave.GamePlayActivityOneData data, Daily_DailyType tData)
	{
	}

	private void RefreshLimitedActivityBtn()
	{
	}

	private void UpdateStatus()
	{
	}

	private void maskShow(bool value)
	{
	}

	protected virtual void onMaskShow(bool value)
	{
	}

	public void UpdateTime()
	{
	}

	protected virtual void RefreshEndTime()
	{
	}

	protected virtual void RefreshStartTime()
	{
	}

	protected virtual List<(string, int)> FilterPropShow(List<(string, int)> originProp)
	{
		return null;
	}

	protected virtual void RefreshData()
	{
	}

	private void RedEnvelope(List<(string, int)> rewardArray, out int nStartIndex)
	{
		nStartIndex = default;
	}

	private bool ConditionOfShowReward(int itemId)
	{
		return false;
	}

	public virtual void OnLanguageChange()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void ShowBtnInfo()
	{
	}
}
