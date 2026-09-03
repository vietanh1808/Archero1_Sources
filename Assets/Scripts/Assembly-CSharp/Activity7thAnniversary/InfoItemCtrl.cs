using System;
using UnityEngine;
using UnityEngine.UI;

namespace Activity7thAnniversary
{
	public class InfoItemCtrl : MonoBehaviour
	{
		[SerializeField]
		private ButtonCtrl _btnInfo;

		[SerializeField]
		private Image _imgBtn;

		public InfoItemCtrl Init(string icon, string lanId, Action<InfoItemCtrl, string, string> onClick)
		{
			return null;
		}
	}
}
