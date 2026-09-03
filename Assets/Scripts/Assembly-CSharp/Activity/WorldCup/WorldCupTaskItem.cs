using TableTool;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class WorldCupTaskItem : MonoBehaviour
	{
		[SerializeField]
		private GameObject goBgComplete;

		[SerializeField]
		private GameObject goFill;

		[SerializeField]
		private ButtonCtrl btnGet;

		[SerializeField]
		private ButtonCtrl btnToFinish;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private DxxImage imgComplete;

		[SerializeField]
		private Image imgProgress;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtBtnGet;

		[SerializeField]
		private DxxText txtBtnGoTo;

		[SerializeField]
		private DxxText txtProgress;

		[SerializeField]
		private DxxText txtCompleted;

		[SerializeField]
		private PropOneEquip[] props;

		private int index;

		private bool isWorld;

		private int count;

		private bool interactable;

		private WorldCup_WorldDailyTask taskConfig;

		private WorldCup_WorldTask achievementConfig;

		private WorldCupTask taskData;

		private WorldCupAchievement achievementData;

		private bool achievementFinished;

		private TaskWorldCupPanel panel;

		private IActivityUI ctrl;

		private void Awake()
		{
		}

		public void Init(IActivityUI ctrl, TaskWorldCupPanel panel, int index, bool isWorld)
		{
		}

		private void SetTexts()
		{
		}

		private void SetButtons()
		{
		}

		private void SetRewards()
		{
		}

		private void SetAvailable()
		{
		}
	}
}
