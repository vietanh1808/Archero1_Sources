using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Lattice
{
	public class RewardSelectTab : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl[] btnsPreview;

		[SerializeField]
		private ButtonCtrl btnConfirm;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTitleSelection;

		[SerializeField]
		private DxxText txtPropDesc;

		[SerializeField]
		private DxxText txtBtnDesc;

		[SerializeField]
		private DxxText txtBtnConfirm;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private PropOneEquip[] props;

		[SerializeField]
		private GameObject[] goEmptySelections;

		[SerializeField]
		private GameObject[] goGotTags;

		[SerializeField]
		private RewardSelectItem template;

		private RewardSelectItem[] items;

		private int[] selectedRewardIndicesStartsFromOne;

		private Drop_DropModel.DropData[] rewards;

		private int lastClickedRewardIndex;

		private RewardPanel panel;

		private static DelegateBridge __Hotfix0_get_anyInvalidSelection;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnConfirm;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_RefreshLattices;

		private static DelegateBridge __Hotfix0_RefreshPreview;

		private static DelegateBridge __Hotfix0_RefreshTexts;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge __Hotfix0_CreateReward;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnSelectIndex;

		private static DelegateBridge __Hotfix0_OnPreviewItemClick;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_IsSelected;

		private static DelegateBridge _c__Hotfix0_ctor;

		private bool anyInvalidSelection => false;

		private void Awake()
		{
		}

		private void OnConfirm()
		{
		}

		public void Init(RewardPanel panel)
		{
		}

		public void Open()
		{
		}

		private void RefreshLattices(bool init)
		{
		}

		private void RefreshPreview()
		{
		}

		private void RefreshTexts()
		{
		}

		private void Refresh(bool init)
		{
		}

		private void Update()
		{
		}

		private RewardSelectItem CreateReward(int i)
		{
			return null;
		}

		public void Close()
		{
		}

		public void OnSelectIndex(int index)
		{
		}

		private void OnPreviewItemClick(int index)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public bool IsSelected(int index)
		{
			return false;
		}
	}
}
