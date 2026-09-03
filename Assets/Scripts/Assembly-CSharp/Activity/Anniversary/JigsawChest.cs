using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class JigsawChest : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private RectTransform rtLight;

		[SerializeField]
		private RedNodeCtrl redNode;

		[SerializeField]
		private DxxText txtProgress;

		[SerializeField]
		private int id;

		[SerializeField]
		private JigsawPanel panel;

		[SerializeField]
		private GameObject goTick;

		[SerializeField]
		private Animation anim;

		private JigsawState state;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		public void Refresh()
		{
		}
	}
}
