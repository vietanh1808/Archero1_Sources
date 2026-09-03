using UnityEngine;

namespace Activity7thAnniversary
{
	public class PlayInfoCtrl : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl _btnClose;

		[SerializeField]
		private DxxText _textTitle;

		[SerializeField]
		private DxxText _textContent;

		public void Init(string content)
		{
		}

		public void OnLanguageChanged(string content)
		{
		}
	}
}
