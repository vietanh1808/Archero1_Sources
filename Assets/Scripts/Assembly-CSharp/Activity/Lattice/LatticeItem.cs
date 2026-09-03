using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class LatticeItem : MonoBehaviour
	{
		[SerializeField]
		private DxxImage imgNormal;

		[SerializeField]
		private DxxImage imgFlipped;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private GameObject goPsNormal;

		[SerializeField]
		private GameObject goPsBig;

		[SerializeField]
		private DxxImage imgNumPop;

		[SerializeField]
		private Sprite[] sprites;

		[SerializeField]
		private float fadeDuration;

		[SerializeField]
		private float popDuration;

		[SerializeField]
		private float moveDuration;

		[SerializeField]
		private float scale;

		[SerializeField]
		private Vector2 moveOffset;

		private int index;

		private LatticePanel panel;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_ReqFlip;

		private static DelegateBridge __Hotfix0_ShowReward;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_DoFlipAnim;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		private void ReqFlip()
		{
		}

		private void ShowReward(List<Drop_DropModel.DropData> drops, Action onFlyEnd)
		{
		}

		public void SetData(int index, LatticePanel latticePanel)
		{
		}

		private void Refresh()
		{
		}

		public void DoFlipAnim(List<Drop_DropModel.DropData> drops, Action onFlyEnd)
		{
		}
	}
}
