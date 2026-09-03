using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

namespace Activity.Wish
{
	public class WishTaskItem : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btnReceive;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtBtnReceive;

		[SerializeField]
		private DxxText txtReceived;

		[SerializeField]
		private RectTransform rewardContentRoot;

		private List<PropOneEquip> list;

		private STActivityWishDailyTaskData data;

		private LocalUnityObjctPool pool;

		private void Awake()
		{
		}

		public void SetData(STActivityWishDailyTaskData task, LocalUnityObjctPool pool)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Refresh()
		{
		}

		private void OnReceive()
		{
		}
	}
}
