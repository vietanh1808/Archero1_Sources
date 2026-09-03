using System.Collections.Generic;
using Habby.Effect;
using UnityEngine;
using UnityEngine.UI;

namespace Dxx.UI
{
	[AddComponentMenu("UI/Effects/OutLineDxx")]
	[RequireComponent(typeof(Text))]
	public class OutLineDxx : Shadow
	{
		private OutLineAndShadow _worker;

		private const bool _useNewShadow = true;

		private const float effectscale = 1.5f;

		private const float DOWNWIDTH = 6f;

		private Text m_Text;

		private List<Vector2> shadowPosList;

		public OutLineAndShadow worker => null;

		public Text text => null;

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private void ShadowModifyMesh(VertexHelper vh)
		{
		}
	}
}
