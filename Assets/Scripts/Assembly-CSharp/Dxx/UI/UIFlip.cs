using UnityEngine;
using UnityEngine.UI;

namespace Dxx.UI
{
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Effects/UI Flip")]
	[RequireComponent(typeof(Graphic))]
	public class UIFlip : BaseMeshEffect
	{
		[SerializeField]
		private bool m_Horizontal;

		[SerializeField]
		private bool m_Veritical;

		public bool horizontal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool vertical
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
