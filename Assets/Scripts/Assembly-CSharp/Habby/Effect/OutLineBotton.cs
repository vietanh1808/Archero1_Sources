using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Habby.Effect
{
	public class OutLineBotton : EffectBase
	{
		private const string shaderName = "UI/OutLineBottomEx";

		private static Material rpMat;

		private static Material defaultMat;

		private int outLineWidth;

		private Text _text;

		private bool isUseDefault;

		private static List<UIVertex> vertexList;

		public Text text => null;

		public bool inited { get; private set; }

		public OutLineBotton(BaseMeshEffect pcmp, Graphic pGraphic)
			: base(null, null)
		{
		}

		public override void Init()
		{
		}

		protected override void RestToDefaultMat()
		{
		}

		protected override void UseNewMat()
		{
		}

		public override void OnDisable()
		{
		}

		public override void OnEnable()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private UIVertex OutPosAndUV(UIVertex pVertex, int pOutLineWidth, Vector2 pPosCenter, Vector2 pTriangleX, Vector2 pTriangleY, Vector2 pUVX, Vector2 pUVY, Vector4 pUVOrigin, int uvType)
		{
			return default;
		}

		private Vector4 GetUVRect(Vector2 uv0, Vector2 uv1, Vector2 uv2)
		{
			return default;
		}
	}
}
