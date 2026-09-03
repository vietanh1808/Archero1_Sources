using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThinkingSDK.PC.Config;
using ThinkingSDK.PC.Constant;
using ThinkingSDK.PC.DataModel;
using ThinkingSDK.PC.Request;
using ThinkingSDK.PC.TaskManager;
using ThinkingSDK.PC.Time;
using UnityEngine;

namespace ThinkingSDK.PC.Main
{
	public class ThinkingSDKInstance
	{
		[CompilerGenerated]
		private sealed class _003CWaitAndFlush_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ThinkingSDKInstance _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitAndFlush_003Ed__42(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private string mAppid;

		private string mServer;

		protected string mDistinctID;

		protected string mAccountID;

		private bool mOptTracking;

		private Dictionary<string, object> mTimeEvents;

		private bool mEnableTracking;

		protected Dictionary<string, object> mSupperProperties;

		protected Dictionary<string, Dictionary<string, object>> mAutoTrackProperties;

		private ThinkingSDKConfig mConfig;

		private ThinkingSDKBaseRequest mRequest;

		private ThinkingSDKTimeCalibration mTimeCalibration;

		private IDynamicSuperProperties mDynamicProperties;

		private static ThinkingSDKInstance mCurrentInstance;

		private MonoBehaviour mMono;

		private static MonoBehaviour sMono;

		private ResponseHandle mResponseHandle;

		private ThinkingSDKTask mTask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SetTimeCalibratieton(ThinkingSDKTimeCalibration timeCalibration)
		{
		}

		private ThinkingSDKInstance()
		{
		}

		private void DefaultData()
		{
		}

		public ThinkingSDKInstance(string appid, string server)
		{
		}

		public ThinkingSDKInstance(string appid, string server, ThinkingSDKConfig config, MonoBehaviour mono = null)
		{
		}

		public static ThinkingSDKInstance CreateLightInstance()
		{
			return null;
		}

		public ThinkingSDKTimeInter GetTime(DateTime dateTime)
		{
			return null;
		}

		public virtual void Identifiy(string distinctID)
		{
		}

		public virtual string DistinctId()
		{
			return null;
		}

		public virtual void Login(string accountID)
		{
		}

		public virtual string AccountID()
		{
			return null;
		}

		public virtual void Logout()
		{
		}

		public virtual void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties)
		{
		}

		public virtual void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties)
		{
		}

		public void Track(string eventName)
		{
		}

		public void Track(string eventName, Dictionary<string, object> properties)
		{
		}

		public void Track(string eventName, Dictionary<string, object> properties, DateTime date)
		{
		}

		public void Track(string eventName, Dictionary<string, object> properties, DateTime date, bool immediately)
		{
		}

		private void SendData(ThinkingSDKEventData data)
		{
		}

		private void SendData(ThinkingSDKEventData data, bool immediately)
		{
		}

		private void SendData(ThinkingSDKBaseData data)
		{
		}

		private void SendData(ThinkingSDKBaseData data, bool immediately)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitAndFlush_003Ed__42))]
		private IEnumerator WaitAndFlush()
		{
			return null;
		}

		public virtual void Flush()
		{
		}

		public void Track(ThinkingSDKEventData analyticsEvent)
		{
		}

		public virtual void SetSuperProperties(Dictionary<string, object> superProperties)
		{
		}

		public virtual void UnsetSuperProperty(string propertyKey)
		{
		}

		public virtual Dictionary<string, object> SuperProperties()
		{
			return null;
		}

		public Dictionary<string, object> PresetProperties()
		{
			return null;
		}

		public virtual void ClearSuperProperties()
		{
		}

		public void TimeEvent(string eventName)
		{
		}

		public void UserSet(Dictionary<string, object> properties)
		{
		}

		public void UserSet(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserUnset(string propertyKey)
		{
		}

		public void UserUnset(string propertyKey, DateTime dateTime)
		{
		}

		public void UserUnset(List<string> propertyKeys)
		{
		}

		public void UserUnset(List<string> propertyKeys, DateTime dateTime)
		{
		}

		public void UserSetOnce(Dictionary<string, object> properties)
		{
		}

		public void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserAdd(Dictionary<string, object> properties)
		{
		}

		public void UserAdd(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserAppend(Dictionary<string, object> properties)
		{
		}

		public void UserAppend(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserDelete()
		{
		}

		public void UserDelete(DateTime dateTime)
		{
		}

		public void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties)
		{
		}

		protected bool IsPaused()
		{
			return false;
		}

		public void OptTracking(bool optTracking)
		{
		}

		public void EnableTracking(bool isEnable)
		{
		}

		private void DefaultTrackState()
		{
		}

		public void OptTrackingAndDeleteUser()
		{
		}

		public string TimeString(DateTime dateTime)
		{
			return null;
		}
	}
}
