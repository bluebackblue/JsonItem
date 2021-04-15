

/** Test_MonoBehaviour
*/
public class Test_MonoBehaviour : BlueBack.JsonItem.JsonItemViewer_MonoBehaviour
{
	/** jsonstring
	*/
	public string jsonstring = "[[\"value\",{\"aaa\":\"xxx\",\"bbb\":{\"abc\":\"xyz\"}},3],-1,1,0.001f,true,null,-3m,\"x\"]";

	/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
	*/
	public override BlueBack.JsonItem.JsonItem GetJsonItem()
	{
		return new BlueBack.JsonItem.JsonItem(this.jsonstring);
	}
}

