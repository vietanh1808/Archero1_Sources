using TableTool;
using UIKit;
using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class TDLevelItem : UITableViewCell
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtWave;

		[SerializeField]
		private DxxText txtBtnPlay;

		[SerializeField]
		private DxxText txtUnlockTime;

		[SerializeField]
		private DxxImage imgBg;

		[SerializeField]
		private DxxImage imgLeft;

		[SerializeField]
		private DxxImage imgRight;

		[SerializeField]
		private ButtonCtrl btnPlay;

		[SerializeField]
		private ButtonCtrl btnChest;

		[SerializeField]
		private GameObject goSelected;

		[SerializeField]
		private GameObject goCheck;

		[SerializeField]
		private RedNodeCtrl redNode;

		private new int index;

		private TowerDefensePanel panel;

		[SerializeField]
		private Sprite spBlue;

		[SerializeField]
		private Sprite spPurple;

		[SerializeField]
		private Sprite spLeftBlue;

		[SerializeField]
		private Sprite spLeftPurple;

		[SerializeField]
		private Sprite spRightBlue;

		[SerializeField]
		private Sprite spRightPurple;

		private Tower_Defense_TDlevel config;

		private float time;

		private int curMaxLevel;

		private static DelegateBridge __Hotfix0_get_realIndex;

		private static DelegateBridge __Hotfix0_get_CanPlay;

		private static DelegateBridge __Hotfix0_get_IsElite;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_get_unlockedLevel;

		private static DelegateBridge __Hotfix0_get_timeTilUnlock;

		private static DelegateBridge __Hotfix0_get_unlockedTime;

		private static DelegateBridge __Hotfix0_RefreshUnlockTime;

		private static DelegateBridge __Hotfix0_OnClickPlay;

		private static DelegateBridge __Hotfix0_OnClickChest;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge _c__Hotfix0_ctor;

		private int realIndex => 0;

		private bool CanPlay => false;

		private bool IsElite => false;

		private bool unlockedLevel => false;

		private long timeTilUnlock => 0L;

		private bool unlockedTime => false;

		protected override void Awake()
		{
		}

		public void SetData(int index, TowerDefensePanel panel)
		{
		}

		private void Refresh()
		{
		}

		private void RefreshUnlockTime()
		{
		}

		private void OnClickPlay()
		{
		}

		private void OnClickChest()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void _003C_003ExLuaBaseProxy_Awake()
		{
		}
	}
}
