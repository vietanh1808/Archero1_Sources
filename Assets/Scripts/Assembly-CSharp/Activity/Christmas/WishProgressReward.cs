using System;
using UnityEngine;

namespace Activity.Christmas
{
	public class WishProgressReward : MonoBehaviour
	{
		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private GameObject goTag;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private DxxText txtProgress;

		[SerializeField]
		private DxxImage imgLight;

		[SerializeField]
		private RedNodeCtrl redNode;

		[SerializeField]
		private float width;

		private bool canClick;

		private int index;

		private Action onClick;

		private void Awake()
		{
		}

		public void Set(int index, Action onClick)
		{
		}
	}
}
