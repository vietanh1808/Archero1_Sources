using TableTool;
using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class TDPopDetailItem : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxImage imgIcon;

		[SerializeField]
		private GameObject goTick;

		[SerializeField]
		private GameObject goLock;

		[SerializeField]
		private ButtonCtrl btn;

		private int index;

		private TDPopPanel panel;

		private int layerId;

		private Tower_Defense_DefenseTower config;

		private static DelegateBridge __Hotfix0_get_unlocked;

		private static DelegateBridge __Hotfix0_get_lockedDesc;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_GetSprite;

		private static DelegateBridge _c__Hotfix0_ctor;

		private bool unlocked => false;

		private string lockedDesc => null;

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		public void SetData(int index, int layerId, TDPopPanel panel)
		{
		}

		public void Refresh()
		{
		}

		private Sprite GetSprite(string name)
		{
			return null;
		}
	}
}
