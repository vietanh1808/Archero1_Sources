using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class TaskWorldCupPanel : PanelBase
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtTimeLeft;

		[SerializeField]
		private DxxText txtTimeBeforeRefresh;

		[SerializeField]
		private DxxText txtBtnDailyTask;

		[SerializeField]
		private DxxText txtBtnDailyTask2;

		[SerializeField]
		private DxxText txtBtnWorldCupTask;

		[SerializeField]
		private DxxText txtBtnWorldCupTask2;

		[SerializeField]
		private GameObject goDailySelected;

		[SerializeField]
		private GameObject goDailyUnselected;

		[SerializeField]
		private GameObject goWorldSelected;

		[SerializeField]
		private GameObject goWorldUnselected;

		[SerializeField]
		private ButtonCtrl btnTabWorld;

		[SerializeField]
		private ButtonCtrl btnTabDaily;

		[SerializeField]
		private ButtonCtrl btnTip;

		[SerializeField]
		private WorldCupTaskInfinity infinity;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private VerticalLayoutGroup layoutGroup;

		[SerializeField]
		private RedNodeCtrl redNodeTask;

		[SerializeField]
		private RedNodeCtrl redNodeAchievement;

		[SerializeField]
		private int delta;

		private bool isWorld;

		private void Awake()
		{
		}

		public override void Init(IActivityUI activityUI)
		{
		}

		public override void Open()
		{
		}

		public void SetTab(bool isWorld)
		{
		}

		public override void Close()
		{
		}

		public override void Refresh()
		{
		}

		public override void OnLanguageChange()
		{
		}
	}
}
