using UnityEngine;

namespace Activity.Christmas
{
	public class GlobalRewardItem : MonoBehaviour
	{
		[SerializeField]
		private PropOneEquip one;

		[SerializeField]
		private DxxText txt;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private GameObject goTagGot;

		[SerializeField]
		private GameObject goImgLight;

		[SerializeField]
		private float width;

		[SerializeField]
		private RedNodeCtrl redNode;

		private int index;

		private bool canClick;

		private void Awake()
		{
		}

		private void OnBtnClick()
		{
		}

		public void Set(int index)
		{
		}
	}
}
