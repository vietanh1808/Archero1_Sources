using UnityEngine;

namespace TableTool
{
	public class Wings_TransformModel : LocalModel<Wings_Transform, int>
	{
		private const string _Filename = "Wings_Transform";

		protected override string Filename => null;

		protected override int GetBeanKey(Wings_Transform bean)
		{
			return 0;
		}

		public Vector3 Offset(int nSkinId, int nWingId)
		{
			return default;
		}

		public Vector3 Rotation(int nSkinId, int nWingId)
		{
			return default;
		}

		public Vector3 Scale(int nSkinId, int nWingId)
		{
			return default;
		}

		public Vector3 Run_Offset(int nSkinId, int nWingId)
		{
			return default;
		}

		public Vector3 Run_Rotation(int nSkinId, int nWingId)
		{
			return default;
		}

		public Vector3 Run_Scale(int nSkinId, int nWingId)
		{
			return default;
		}

		private bool parseArgs(int nSkinId, int nWingId, int index, out Vector3 value, string suffix = "")
		{
			value = default;
			return false;
		}
	}
}
