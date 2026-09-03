using UnityEngine;
using XLua;

namespace Activity.Bingo
{
	public class BingoItem : MonoBehaviour
	{
		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private GameObject gameObjectTick;

		[SerializeField]
		private DxxImage imgBg;

		[SerializeField]
		private GameObject coverObj;

		[SerializeField]
		private GameObject effectObj;

		public Transform root;

		private int index;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_Start;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_HideCover;

		private static DelegateBridge __Hotfix0_ShowEffect;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void SetData(int index)
		{
		}

		public void HideCover()
		{
		}

		public void ShowEffect()
		{
		}

		public void Refresh()
		{
		}
	}
}
