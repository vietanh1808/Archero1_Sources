using UnityEngine;
using UnityEngine.UI;

namespace UPersian.Components
{
	[AddComponentMenu("UI/RtlText")]
	public class RtlText : Text
	{
		protected char LineEnding;

		public string BaseText => null;

		public override string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
