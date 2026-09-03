using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Habby.Effect
{
	public class OutLineAndShadow : EffectBase
	{
		private const string shaderName = "UI/OutLine_new";

		private static Material rpMat;

		private static Material defaultMat;

		private Text _text;

		private bool isUseDefault;

		private static List<UIVertex> output;

		public Text text => null;

		public bool inited { get; private set; }

		public OutLineAndShadow(BaseMeshEffect pcmp, Graphic pGraphic)
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

		private void SetData(ref UIVertex vVertex, ref Vector4 uvBounds)
		{
		}
	}
}
