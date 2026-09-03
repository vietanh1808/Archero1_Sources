using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

namespace Activity.Christmas
{
	public class ChristmasActivityTaskItem : MonoBehaviour
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

		private STActivityChristmasActiveTaskData cachedData;

		private LocalUnityObjctPool pool;

		private TaskPanel panel;

		private void Awake()
		{
		}

		public void SetData(STActivityChristmasActiveTaskData data, TaskPanel taskPanel, LocalUnityObjctPool pool)
		{
		}

		private void Refresh()
		{
		}

		private void Receive()
		{
		}
	}
}
