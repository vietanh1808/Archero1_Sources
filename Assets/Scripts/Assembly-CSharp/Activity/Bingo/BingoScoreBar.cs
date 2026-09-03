using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Bingo
{
	public class BingoScoreBar : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtScore;

		[SerializeField]
		private BingoScoreBarItem template;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private RectTransform rtRoot;

		private LocalUnityObjctPool pool;

		private List<BingoScoreBarItem> items;

		private BingoCountReward[] rewards;

		private static DelegateBridge __Hotfix0_SetUp;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_GetValue;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void SetUp()
		{
		}

		public void Refresh(bool init)
		{
		}

		private float GetValue()
		{
			return 0f;
		}
	}
}
