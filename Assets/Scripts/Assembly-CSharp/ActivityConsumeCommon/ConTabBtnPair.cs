using System;
using UnityEngine;
using UnityEngine.UI;

namespace ActivityConsumeCommon
{
	[Serializable]
	public struct ConTabBtnPair
	{
		public ConsumeTab tab;

		public ButtonCtrl btn;

		public GameObject mini;

		public GameObject big;

		public Image ImageBig;
	}
}
