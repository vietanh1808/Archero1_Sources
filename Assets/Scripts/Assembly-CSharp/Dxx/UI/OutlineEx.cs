using Habby.Effect;
using UnityEngine.UI;

namespace Dxx.UI
{
	public class OutlineEx : BaseMeshEffect
	{
		private OutLineAndShadow _worker;

		public OutLineAndShadow worker => null;

		protected override void Awake()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
