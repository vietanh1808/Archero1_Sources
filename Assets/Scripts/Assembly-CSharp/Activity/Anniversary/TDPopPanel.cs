using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Anniversary
{
	public class TDPopPanel : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBg;

		[SerializeField]
		private ButtonCtrl btnPlay;

		[SerializeField]
		private ButtonCtrl btnRaid;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtWave;

		[SerializeField]
		private DxxText txtBtnPlayCost;

		[SerializeField]
		private DxxText txtBtnRaid;

		[SerializeField]
		private DxxText txtBtnRaidChances;

		[SerializeField]
		private DxxText txtRaidReset;

		[SerializeField]
		private DxxText txtTitleSelect;

		[SerializeField]
		private DxxText txtTitleReward;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private RectTransform rtItemsRoot;

		[SerializeField]
		private RectTransform rtRewardRoot;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private TDPopDetailItem detailTemplate;

		[SerializeField]
		private List<PropOneEquip> propItems;

		[SerializeField]
		private TDPopSelectItem[] selectItems;

		[SerializeField]
		private List<TDPopDetailItem> detailItems;

		private long timeEndToday;

		private int index;

		private List<int> selection;

		private int towerLimit;

		private Tower_Defense_TDlevel config;

		private LayerData data;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_ReloadDetailItems;

		private static DelegateBridge __Hotfix0_RefreshDetailItems;

		private static DelegateBridge __Hotfix0_RefreshRewards;

		private static DelegateBridge __Hotfix0_RefreshSelection;

		private static DelegateBridge __Hotfix0_SetTexts;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnClickPlay;

		private static DelegateBridge __Hotfix0_OnClickRaid;

		private static DelegateBridge __Hotfix0_Select;

		private static DelegateBridge __Hotfix0_IsIdSelected;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void Open(int index)
		{
		}

		private void Refresh()
		{
		}

		private void ReloadDetailItems()
		{
		}

		private void RefreshDetailItems()
		{
		}

		private void RefreshRewards()
		{
		}

		private void RefreshSelection()
		{
		}

		private void SetTexts()
		{
		}

		public void Close()
		{
		}

		private void OnClickPlay()
		{
		}

		private void OnClickRaid()
		{
		}

		public bool Select(int id)
		{
			return false;
		}

		public bool IsIdSelected(int id)
		{
			return false;
		}
	}
}
