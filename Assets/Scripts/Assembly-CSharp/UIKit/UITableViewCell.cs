using UnityEngine;

namespace UIKit
{
	public class UITableViewCell : MonoBehaviour
	{
		public RectTransform rectTransform { get; private set; }

		public string reuseIdentifier { get; internal set; }

		public bool isAutoResize { get; internal set; }

		public UITableViewCellLifeCycle lifeCycle { get; internal set; }

		public int? index { get; internal set; }

		protected virtual void Awake()
		{
		}
	}
}
