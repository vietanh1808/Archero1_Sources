using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

namespace Activity.Christmas
{
	public class ChristmasDailyTaskItem : MonoBehaviour
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

		private STActivityChristmasDailyTaskData data;

		private LocalUnityObjctPool pool;

		private void Awake()
		{
		}

		public void SetData(STActivityChristmasDailyTaskData task, LocalUnityObjctPool pool)
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
