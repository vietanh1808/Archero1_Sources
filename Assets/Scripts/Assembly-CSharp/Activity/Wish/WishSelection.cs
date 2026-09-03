using UnityEngine;

namespace Activity.Wish
{
	public class WishSelection : MonoBehaviour
	{
		[SerializeField]
		private SelectTab selectTab;

		[SerializeField]
		private PreviewTab previewTab;

		[SerializeField]
		private ButtonCtrl btnSelect;

		[SerializeField]
		private ButtonCtrl btnPreview;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnShadow;

		[SerializeField]
		private DxxText txtSelect;

		[SerializeField]
		private DxxText txtSelect2;

		[SerializeField]
		private DxxText txtPreview;

		[SerializeField]
		private DxxText txtPreview2;

		[SerializeField]
		private DxxText txt_SelectTips;

		[SerializeField]
		private GameObjectActivator tabActivator;

		[SerializeField]
		private GameObject goTabs;

		private void Awake()
		{
		}

		private void OpenPreview()
		{
		}

		private void OpenSelect()
		{
		}

		public void Open()
		{
		}

		public void Close()
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

		public void SetWishPanel(WishPanel wishPanel)
		{
		}
	}
}
