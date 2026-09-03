using UnityEngine.UI;

namespace Habby.Effect
{
	public abstract class EffectBase
	{
		protected BaseMeshEffect effectComp;

		protected Graphic graphic;

		public EffectBase(BaseMeshEffect pcmp, Graphic pGraphic)
		{
		}

		public abstract void Init();

		public abstract void ModifyMesh(VertexHelper vh);

		protected virtual void RestToDefaultMat()
		{
		}

		protected virtual void UseNewMat()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void AddUV1_3ToCanvas()
		{
		}
	}
}
