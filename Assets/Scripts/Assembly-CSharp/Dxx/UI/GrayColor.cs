using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dxx.UI
{
	[AddComponentMenu("UI/Effects/Gray Color")]
	[RequireComponent(typeof(Graphic))]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class GrayColor : UIBehaviour
	{
		public Material hueMaterial;

		private Graphic m_Graphic;

		public Graphic graphic => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
