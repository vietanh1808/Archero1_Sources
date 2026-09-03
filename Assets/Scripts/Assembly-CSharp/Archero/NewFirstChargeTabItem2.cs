using System;
using UnityEngine;

namespace Archero
{
	public class NewFirstChargeTabItem2 : MonoBehaviour
	{
		public ButtonCtrl clickBtn;

		public DxxText tabTex;

		public DxxText tabFocusTex;

		public GameObject focusObj;

		private Action<int> ClickCallBack;

		private int index;

		private void Awake()
		{
		}

		public void HideFocus()
		{
		}

		public void Init(int tabIndex, Action<int> clickDo)
		{
		}

		public void ClickTab()
		{
		}
	}
}
