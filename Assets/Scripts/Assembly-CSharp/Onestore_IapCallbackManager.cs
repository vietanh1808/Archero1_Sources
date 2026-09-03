using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using OneStore;
using UnityEngine;

public class Onestore_IapCallbackManager : MonoBehaviour
{
	private enum CBType
	{
		Connected = 0,
		Disconnected = 1,
		NeedUpdate = 2,
		Success = 3,
		Error = 4,
		RemoteEx = 5,
		SecurityEx = 6
	}

	[CompilerGenerated]
	private static Action m_serviceAvailableEvent;

	[CompilerGenerated]
	private static Action<string> m_serviceConnectionEvent;

	[CompilerGenerated]
	private static Action<string> m_isBillingSupportedEvent;

	[CompilerGenerated]
	private static Action<PurchaseData> m_getPurchaseSuccessEvent;

	[CompilerGenerated]
	private static Action<string> m_getPurchaseErrorEvent;

	[CompilerGenerated]
	private static Action<ProductDetail> m_queryProductsSuccessEvent;

	[CompilerGenerated]
	private static Action<string> m_queryProductsErrorEvent;

	[CompilerGenerated]
	private static Action<PurchaseData> m_getPurchaseIntentSuccessEvent;

	[CompilerGenerated]
	private static Action<string> m_getPurchaseIntentErrorEvent;

	[CompilerGenerated]
	private static Action<PurchaseData> m_consumeSuccessEvent;

	[CompilerGenerated]
	private static Action<string> m_consumeErrorEvent;

	[CompilerGenerated]
	private static Action<PurchaseData> m_manageRecurringSuccessEvent;

	[CompilerGenerated]
	private static Action<string> m_manageRecurringErrorEvent;

	[CompilerGenerated]
	private static Action<string> m_getLoginIntentEvent;

	private Dictionary<CBType, string> preDefinedStrings;

	public static event Action serviceAvailableEvent
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

	public static event Action<string> serviceConnectionEvent
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

	public static event Action<string> isBillingSupportedEvent
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

	public static event Action<PurchaseData> getPurchaseSuccessEvent
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

	public static event Action<string> getPurchaseErrorEvent
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

	public static event Action<ProductDetail> queryProductsSuccessEvent
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

	public static event Action<string> queryProductsErrorEvent
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

	public static event Action<PurchaseData> getPurchaseIntentSuccessEvent
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

	public static event Action<string> getPurchaseIntentErrorEvent
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

	public static event Action<PurchaseData> consumeSuccessEvent
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

	public static event Action<string> consumeErrorEvent
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

	public static event Action<PurchaseData> manageRecurringSuccessEvent
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

	public static event Action<string> manageRecurringErrorEvent
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

	public static event Action<string> getLoginIntentEvent
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

	private void Start()
	{
	}

	public void ServiceConnectionListener(string callback)
	{
	}

	public void BillingSupportedListener(string callback)
	{
	}

	public void QueryPurchaseListener(string callback)
	{
	}

	public void QueryProductsListener(string callback)
	{
	}

	public void PurchaseFlowListener(string callback)
	{
	}

	public void ConsumeListener(string callback)
	{
	}

	public void ManageRecurringProductListener(string callback)
	{
	}

	public void LoginFlowListener(string callback)
	{
	}

	private string findStringAfterCBType(string data, CBType type)
	{
		return null;
	}
}
