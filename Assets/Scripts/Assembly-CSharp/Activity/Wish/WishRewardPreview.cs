using UnityEngine;

namespace Activity.Wish
{
	public class WishRewardPreview : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtRewardsTitle;

		[SerializeField]
		private PropOneEquip template;

		[SerializeField]
		private RectTransform rtContentRoot;

		private LocalUnityObjctPool _pool;

		private LocalUnityObjctPool pool => null;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		private void android_escape()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLanguageChange()
		{
		}
	}
}
