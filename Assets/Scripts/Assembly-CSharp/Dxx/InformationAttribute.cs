using UnityEngine;

namespace Dxx
{
	public class InformationAttribute : PropertyAttribute
	{
		public enum InformationType
		{
			Error = 0,
			Info = 1,
			None = 2,
			Warning = 3
		}

		public InformationAttribute(string message, InformationType type, bool messageAfterProperty)
		{
		}
	}
}
