using System.Collections.Generic;
using ActivityConsumeCommon;
using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class PersonalTaskItem : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtProgress;

		[SerializeField]
		private DxxText txtBtnClaim;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private RectTransform rtContentRoot;

		[SerializeField]
		private DxxImage image_title;

		[SerializeField]
		private DxxImage image_bottom;

		[SerializeField]
		private DxxImage image_get;

		private string atlasName;

		private List<PropOneEquip> cachedPropOnes;

		private ConsumeTab crtTab;

		private TaskType type;

		private LocalUnityObjctPool pool;

		private Color completedColor;

		private Color defaultColor;

		private ConsumeTaskItemData taskData;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_Set;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		public void Set(LocalUnityObjctPool pool, ConsumeTab tab, ConsumeTaskItemData taskData)
		{
		}

		private void Refresh()
		{
		}
	}
}
