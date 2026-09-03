using UnityEngine;
using UnityEngine.UI;

namespace Activity.Wish
{
	public class GiftPackPanel : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtTimeLeft;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBG;

		[SerializeField]
		private GiftPackItem template;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private RectTransform rtContentRoot;

		[SerializeField]
		private ScrollRect scrollRect;

		private LocalUnityObjctPool pool;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		private void Refresh()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void android_escape()
		{
		}
	}
}
