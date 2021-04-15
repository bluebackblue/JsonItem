

/** Test_MonoBehaviour
*/
public class Test_MonoBehaviour : BlueBack.JsonItem.InspectorViewer_MonoBehaviour
{
	/** jsonstring
	*/
	public string jsonstring_1 = "{\"aiueo\":<E38182E38184E38186E38188E3818AE38182E38184E38186E38188E3818A>}";
	public string jsonstring_2 = "null";
	public string jsonstring_3 = "[[\"value\",{\"aaa\":\"xxx\",\"bbb\":{\"abc\":\"xyz\"}},3],-1,1,0.001f,true,null,-3m,\"x\"]";

	/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
	*/
	#if(UNITY_EDITOR)
	public override BlueBack.JsonItem.JsonItem GetJsonItem()
	{
		return new BlueBack.JsonItem.JsonItem(this.jsonstring_1);
	}
	#endif

	/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
	*/
	#if(UNITY_EDITOR)
	public override BlueBack.JsonItem.JsonItem[] GetMultiJsonItem()
	{
		return new BlueBack.JsonItem.JsonItem[]{
			new BlueBack.JsonItem.JsonItem(this.jsonstring_1),
			new BlueBack.JsonItem.JsonItem(this.jsonstring_2),
			new BlueBack.JsonItem.JsonItem(this.jsonstring_3),
		};
	}
	#endif
}

