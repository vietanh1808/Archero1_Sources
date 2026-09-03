using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.Wish
{
	public class PreviewTab : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTitleSelection;

		[SerializeField]
		private ScrollRectBase scrollRect;

		[SerializeField]
		private RectTransform rtContentRoot;

		[SerializeField]
		private GridLayoutGroup gridLayoutGroup;

		private LocalUnityObjctPool pool;

		[SerializeField]
		private PropOneEquip template;

		private List<PropOneEquip> equipOnes;

		private PurchaseWishingReward nextWishingReward => null;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
