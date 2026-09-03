using UnityEngine;
using UnityEngine.UI;

namespace Activity.Wish
{
	public class WishRoundPreview : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private WishRoundItem[] items;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBg;

		private LocalUnityObjctPool pool;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		private void Close()
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
