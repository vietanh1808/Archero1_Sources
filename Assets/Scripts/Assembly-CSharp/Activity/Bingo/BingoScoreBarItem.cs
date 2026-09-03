using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Bingo
{
	public class BingoScoreBarItem : MonoBehaviour
	{
		private static List<BingoScoreBarItem> activatedItems;

		[SerializeField]
		private DxxText txtScore;

		[SerializeField]
		private Image imgBox;

		[SerializeField]
		private Animation anim;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private Sprite spNormal;

		[SerializeField]
		private Sprite spBig;

		[SerializeField]
		private Sprite spHuge;

		[SerializeField]
		private GameObject goPop;

		[SerializeField]
		private RectTransform rtRewardRoot;

		[SerializeField]
		private PropOneEquip propPrefab;

		private int index;

		private Camera uiCamera;

		private static DelegateBridge __Hotfix0_get_reward;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_ClosePop;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnBtnClick;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge _c__Hotfix0_ctor;

		private BingoCountReward reward => null;

		private void Awake()
		{
		}

		public void ClosePop()
		{
		}

		public void SetData(int index)
		{
		}

		public void Refresh()
		{
		}

		private void OnBtnClick()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}
	}
}
