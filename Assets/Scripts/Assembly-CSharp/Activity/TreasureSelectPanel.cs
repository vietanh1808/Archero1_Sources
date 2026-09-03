using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class TreasureSelectPanel : MonoBehaviour
	{
		[SerializeField]
		private ActivityCommonUICtrl ctrl;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTitleSelection;

		[SerializeField]
		private DxxText txtItemDesc;

		[SerializeField]
		private DxxText txtBtnConfirm;

		[SerializeField]
		private ButtonCtrl btnConfirm;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBg;

		[SerializeField]
		private RectTransform rtRewardRoot;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private GameObject goAdd;

		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private PropOneEquip propAnim;

		[SerializeField]
		private TreasureSelectItem template;

		private bool tweening;

		private LocalUnityObjctPool pool;

		private int index;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnConfirm;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_RefreshCandidates;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_RefreshLanguage;

		private static DelegateBridge __Hotfix0_SelectIndex;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnConfirm()
		{
		}

		public void Open()
		{
		}

		private void RefreshCandidates(bool refreshIndex = false)
		{
		}

		public void Close()
		{
		}

		private void RefreshLanguage()
		{
		}

		public void SelectIndex(int index, Transform transform)
		{
		}
	}
}
