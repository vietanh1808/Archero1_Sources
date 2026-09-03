using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Habby.ContentBox.ThirdParty
{
	public class DoTweenInterFace
	{
		public static Tweener DOFade(AudioSource target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOPitch(AudioSource target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOAspect(Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(Camera target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFarClipPlane(Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFieldOfView(Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DONearClipPlane(Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOOrthoSize(Camera target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOPixelRect(Camera target, Rect endValue, float duration)
		{
			return null;
		}

		public static Tweener DORect(Camera target, Rect endValue, float duration)
		{
			return null;
		}

		public static Tweener DOShakePosition(Camera target, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakePosition(Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(Camera target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(Camera target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOColor(Light target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOIntensity(Light target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOShadowStrength(Light target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(LineRenderer target, Color2 startValue, Color2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(Material target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(Material target, Color endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOFade(Material target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(Material target, float endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOFloat(Material target, float endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOOffset(Material target, Vector2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOOffset(Material target, Vector2 endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOTiling(Material target, Vector2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOTiling(Material target, Vector2 endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOVector(Material target, Vector4 endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOMove(Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveX(Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveY(Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveZ(Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DORotate(Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOLookAt(Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			return null;
		}

		public static Sequence DOJump(Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		public static Tweener DOResize(TrailRenderer target, float toStartWidth, float toEndWidth, float duration)
		{
			return null;
		}

		public static Tweener DOTime(TrailRenderer target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOMove(Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveX(Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveY(Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveZ(Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMove(Transform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMoveX(Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMoveY(Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOLocalMoveZ(Transform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DORotate(Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DORotateQuaternion(Transform target, Quaternion endValue, float duration)
		{
			return null;
		}

		public static Tweener DOLocalRotate(Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOLocalRotateQuaternion(Transform target, Quaternion endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScale(Transform target, Vector3 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScale(Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScaleX(Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScaleY(Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScaleZ(Transform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOLookAt(Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, Vector3? up = null)
		{
			return null;
		}

		public static Tweener DOPunchPosition(Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOPunchScale(Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		public static Tweener DOPunchRotation(Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		public static Tweener DOShakePosition(Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakePosition(Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(Transform target, float duration, float strength = 90f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeRotation(Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeScale(Transform target, float duration, float strength = 1f, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeScale(Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		public static Sequence DOJump(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static Sequence DOLocalJump(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, Color? gizmoColor = null)
		{
			return null;
		}

		public static Tweener DOBlendableColor(Light target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(Material target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(Material target, Color endValue, string property, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableMoveBy(Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOBlendableLocalMoveBy(Transform target, Vector3 byValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOBlendableRotateBy(Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOBlendableLocalRotateBy(Transform target, Vector3 byValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static Tweener DOBlendableScaleBy(Transform target, Vector3 byValue, float duration)
		{
			return null;
		}

		public static int DOComplete(Component target, bool withCallbacks = false)
		{
			return 0;
		}

		public static int DOComplete(Material target, bool withCallbacks = false)
		{
			return 0;
		}

		public static int DOKill(Component target, bool complete = false)
		{
			return 0;
		}

		public static int DOKill(Material target, bool complete = false)
		{
			return 0;
		}

		public static int DOFlip(Component target)
		{
			return 0;
		}

		public static int DOFlip(Material target)
		{
			return 0;
		}

		public static int DOGoto(Component target, float to, bool andPlay = false)
		{
			return 0;
		}

		public static int DOGoto(Material target, float to, bool andPlay = false)
		{
			return 0;
		}

		public static int DOPause(Component target)
		{
			return 0;
		}

		public static int DOPause(Material target)
		{
			return 0;
		}

		public static int DOPlay(Component target)
		{
			return 0;
		}

		public static int DOPlay(Material target)
		{
			return 0;
		}

		public static int DOPlayBackwards(Component target)
		{
			return 0;
		}

		public static int DOPlayBackwards(Material target)
		{
			return 0;
		}

		public static int DOPlayForward(Component target)
		{
			return 0;
		}

		public static int DOPlayForward(Material target)
		{
			return 0;
		}

		public static int DORestart(Component target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DORestart(Material target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DORewind(Component target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DORewind(Material target, bool includeDelay = true)
		{
			return 0;
		}

		public static int DOSmoothRewind(Component target)
		{
			return 0;
		}

		public static int DOSmoothRewind(Material target)
		{
			return 0;
		}

		public static int DOTogglePause(Component target)
		{
			return 0;
		}

		public static int DOTogglePause(Material target)
		{
			return 0;
		}

		public static Sequence DOGradientColor(Material target, Gradient gradient, float duration)
		{
			return null;
		}

		public static Sequence DOGradientColor(Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		public static Tweener DOColor(SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		public static Sequence DOGradientColor(SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		public static Tweener DOMove(Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveX(Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMoveY(Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DORotate(Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		public static Sequence DOJump(Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOBlendableColor(SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(Graphic target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(Graphic target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOColor(Image target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(Image target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFillAmount(Image target, float endValue, float duration)
		{
			return null;
		}

		public static Sequence DOGradientColor(Image target, Gradient gradient, float duration)
		{
			return null;
		}

		public static Tweener DOFlexibleSize(LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOMinSize(LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOPreferredSize(LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOColor(Outline target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(Outline target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOScale(Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOAnchorPos(RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOAnchorPosX(RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOAnchorPosY(RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOAnchorPos3D(RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOAnchorMax(RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOAnchorMin(RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOPivot(RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		public static Tweener DOPivotX(RectTransform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOPivotY(RectTransform target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOSizeDelta(RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOPunchAnchorPos(RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOShakeAnchorPos(RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		public static Tweener DOShakeAnchorPos(RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		public static Sequence DOJumpAnchorPos(RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DONormalizedPos(ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOHorizontalNormalizedPos(ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOVerticalNormalizedPos(ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOValue(Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOColor(Text target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOFade(Text target, float endValue, float duration)
		{
			return null;
		}

		public static Tweener DOText(Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
		{
			return null;
		}

		public static Tweener DOBlendableColor(Graphic target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(Image target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(Text target, Color endValue, float duration)
		{
			return null;
		}

		public static Tweener DOSetFloat(AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		public static int DOComplete(AudioMixer target, bool withCallbacks = false)
		{
			return 0;
		}

		public static int DOKill(AudioMixer target, bool complete = false)
		{
			return 0;
		}

		public static int DOFlip(AudioMixer target)
		{
			return 0;
		}

		public static int DOGoto(AudioMixer target, float to, bool andPlay = false)
		{
			return 0;
		}

		public static int DOPause(AudioMixer target)
		{
			return 0;
		}

		public static int DOPlay(AudioMixer target)
		{
			return 0;
		}

		public static int DOPlayBackwards(AudioMixer target)
		{
			return 0;
		}

		public static int DOPlayForward(AudioMixer target)
		{
			return 0;
		}

		public static int DORestart(AudioMixer target)
		{
			return 0;
		}

		public static int DORewind(AudioMixer target)
		{
			return 0;
		}

		public static int DOSmoothRewind(AudioMixer target)
		{
			return 0;
		}

		public static int DOTogglePause(AudioMixer target)
		{
			return 0;
		}

		public static Tweener DOSpiral(Transform target, float duration, Vector3? axis = null, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		public static Tweener DOSpiral(Rigidbody target, float duration, Vector3? axis = null, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
