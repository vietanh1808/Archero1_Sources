using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ara
{
	[ExecuteInEditMode]
	public class AraTrail : MonoBehaviour
	{
		public enum TrailAlignment
		{
			View = 0,
			Velocity = 1,
			Local = 2
		}

		public enum Timescale
		{
			Normal = 0,
			Unscaled = 1
		}

		public enum TextureMode
		{
			Stretch = 0,
			Tile = 1
		}

		public struct CurveFrame
		{
			public Vector3 position;

			public Vector3 normal;

			public Vector3 bitangent;

			public Vector3 tangent;

			public CurveFrame(Vector3 position, Vector3 normal, Vector3 bitangent, Vector3 tangent)
			{
				this.position = default;
				this.normal = default;
				this.bitangent = default;
				this.tangent = default;
			}

			public Vector3 Transport(Vector3 newTangent, Vector3 newPosition)
			{
				return default;
			}
		}

		public struct Point
		{
			public Vector3 position;

			public Vector3 velocity;

			public Vector3 tangent;

			public Vector3 normal;

			public Color color;

			public float thickness;

			public float life;

			public bool discontinuous;

			public Point(Vector3 position, Vector3 velocity, Vector3 tangent, Vector3 normal, Color color, float thickness, float lifetime)
			{
				this.position = default;
				this.velocity = default;
				this.tangent = default;
				this.normal = default;
				this.color = default;
				this.thickness = 0f;
				life = 0f;
				discontinuous = false;
			}

			private static float CatmullRom(float p0, float p1, float p2, float p3, float t)
			{
				return 0f;
			}

			private static Color CatmullRomColor(Color p0, Color p1, Color p2, Color p3, float t)
			{
				return default;
			}

			private static Vector3 CatmullRom3D(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
			{
				return default;
			}

			public static Point Interpolate(Point a, Point b, Point c, Point d, float t)
			{
				return default;
			}

			public static Point operator +(Point p1, Point p2)
			{
				return default;
			}

			public static Point operator -(Point p1, Point p2)
			{
				return default;
			}
		}

		public const float epsilon = 1E-05f;

		[Header("Overall")]
		[Tooltip("Whether to use world or local space to generate and simulate the trail.")]
		public Space space;

		[Tooltip("Whether to use regular time.")]
		public Timescale timescale;

		[Tooltip("How to align the trail geometry: facing the camera (view) of using the transform's rotation (local).")]
		public TrailAlignment alignment;

		[Tooltip("Thickness multiplier, in meters.")]
		public float thickness;

		[Tooltip("Amount of smoothing iterations applied to the trail shape.")]
		[Range(1f, 8f)]
		public int smoothness;

		[Tooltip("Calculate accurate thickness at sharp corners.")]
		public bool highQualityCorners;

		[Range(0f, 12f)]
		public int cornerRoundness;

		[Header("Lenght")]
		[Tooltip("How should the thickness of the curve evolve over its lenght. The horizontal axis is normalized lenght (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
		public AnimationCurve thicknessOverLenght;

		[Tooltip("How should vertex color evolve over the trail's length.")]
		public Gradient colorOverLenght;

		[Header("Time")]
		[Tooltip("How should the thickness of the curve evolve with its lifetime. The horizontal axis is normalized lifetime (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
		public AnimationCurve thicknessOverTime;

		[Tooltip("How should vertex color evolve over the trail's lifetime.")]
		public Gradient colorOverTime;

		[Header("Emission")]
		public bool emit;

		[Tooltip("Initial thickness of trail points when they are first spawned.")]
		public float initialThickness;

		[Tooltip("Initial color of trail points when they are first spawned.")]
		public Color initialColor;

		[Tooltip("Initial velocity of trail points when they are first spawned.")]
		public Vector3 initialVelocity;

		[Tooltip("Minimum amount of time (in seconds) that must pass before spawning a new point.")]
		public float timeInterval;

		[Tooltip("Minimum distance (in meters) that must be left between consecutive points in the trail.")]
		public float minDistance;

		[Tooltip("Duration of the trail (in seconds).")]
		public float time;

		[Header("Physics")]
		[Tooltip("Toggles trail physics.")]
		public bool enablePhysics;

		[Tooltip("Amount of seconds pre-simulated before the trail appears. Useful when you want a trail to be already simulating when the game starts.")]
		public float warmup;

		[Tooltip("Gravity affecting the trail.")]
		public Vector3 gravity;

		[Tooltip("Amount of speed transferred from the transform to the trail. 0 means no velocity is transferred, 1 means 100% of the velocity is transferred.")]
		[Range(0f, 1f)]
		public float inertia;

		[Tooltip("Amount of temporal smoothing applied to the velocity transferred from the transform to the trail.")]
		[Range(0f, 1f)]
		public float velocitySmoothing;

		[Tooltip("Amount of damping applied to the trail's velocity. Larger values will slow down the trail more as time passes.")]
		[Range(0f, 1f)]
		public float damping;

		[Header("Rendering")]
		public Material[] materials;

		private Material[] newTransMaterials;

		public ShadowCastingMode castShadows;

		public bool receiveShadows;

		public bool useLightProbes;

		[Header("Texture")]
		[Tooltip("How to apply the texture over the trail: stretch it all over its lenght, or tile it.")]
		public TextureMode textureMode;

		[Tooltip("When the texture mode is set to 'Tile', defines the width of each tile.")]
		public float uvFactor;

		[Tooltip("When the texture mode is set to 'Tile', defines where to begin tiling from: 0 means the start of the trail, 1 means the end.")]
		[Range(0f, 1f)]
		public float tileAnchor;

		[CompilerGenerated]
		private Action m_onUpdatePoints;

		[HideInInspector]
		public List<Point> points;

		private List<Point> renderablePoints;

		private List<int> discontinuities;

		private Mesh mesh_;

		private Vector3 velocity;

		private Vector3 prevPosition;

		private float speed;

		private float accumTime;

		private List<Vector3> vertices;

		private List<Vector3> normals;

		private List<Vector4> tangents;

		private List<Vector2> uvs;

		private List<Color> vertColors;

		private List<int> tris;

		private float DeltaTime => 0f;

		private float FixedDeltaTime => 0f;

		public Mesh mesh => null;

		public event Action onUpdatePoints
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnValidate()
		{
		}

		public void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Clear()
		{
		}

		public void SetNewTransMaterials(Material[] newMaterials)
		{
		}

		private void UpdateVelocity()
		{
		}

		private void LateUpdate()
		{
		}

		private void EmissionStep(float time)
		{
		}

		private void Warmup()
		{
		}

		private void PhysicsStep(float timestep)
		{
		}

		private void FixedUpdate()
		{
		}

		public void EmitPoint(Vector3 position)
		{
		}

		private void SnapLastPointToTransform()
		{
		}

		private void UpdatePointsLifecycle()
		{
		}

		private void ClearMeshData()
		{
		}

		private void CommitMeshData()
		{
		}

		private void RenderMesh(Camera cam)
		{
		}

		public float GetLenght(List<Point> input)
		{
			return 0f;
		}

		private List<Point> GetRenderablePoints(List<Point> input, int start, int end)
		{
			return null;
		}

		private CurveFrame InitializeCurveFrame(Vector3 point, Vector3 nextPoint)
		{
			return default;
		}

		private void UpdateTrailMesh(Camera cam)
		{
		}

		private void UpdateSegmentMesh(List<Point> input, int start, int end, Vector3 localCamPosition)
		{
		}
	}
}
