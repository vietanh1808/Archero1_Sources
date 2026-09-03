using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class GlobalRewardItem : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private DxxText txtProgress;

		[SerializeField]
		private GameObject goGot;

		[SerializeField]
		private Transform tLight;

		private int index;

		private TaskType type;

		private int stage;

		private LocalUnityObjctPool pool;

		private static readonly Dictionary<int, string[]> progresses;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_Set;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_IsGot;

		private static DelegateBridge __Hotfix0_CanGet;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		public void Set(int stage, int index)
		{
		}

		private void Refresh()
		{
		}

		private bool IsGot()
		{
			return false;
		}

		private bool CanGet()
		{
			return false;
		}

		private void Update()
		{
		}
	}
}
