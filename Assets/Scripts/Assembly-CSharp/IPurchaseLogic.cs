using System;
using GameProtocol;

public interface IPurchaseLogic
{
	void Init();

	bool IsValid();

	bool IsDiscount(string productid);

	bool IsMainActivuty(string productid);

	string GetProduct_localpricestring(int index);

	string GetProduct_localpricestring(string id);

	string GetProductID(int index);

	void SetOpenSource(ShopOpenSource source);

	ShopOpenSource GetOpenSource();

	void OnPurchaseClicked(string productId, Action<bool, CRespInAppPurchase> callback = null);

	void update();

	bool IsPurchasing();

	void OnResume();
}
