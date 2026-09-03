using UnityEngine;
using UnityEngine.UI;

namespace Activity.Christmas
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

		public void Close()
		{
		}
	}
}
