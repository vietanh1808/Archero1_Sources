using UnityEngine;

namespace Activity.Anniversary
{
	public class InfoPopPanel : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBg;

		private void Awake()
		{
		}

		public void Open(string title, string content)
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
	}
}
