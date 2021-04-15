

/** Test_MonoBehaviour
*/
public class Test_JsonItemViewer_MonoBehaviour : BlueBack.JsonItem.JsonItemViewer_MonoBehaviour
{
	/** 表示するJsonItemの取得。
	*/
	public override BlueBack.JsonItem.JsonItem GetJsonItem()
	{
		return new BlueBack.JsonItem.JsonItem(this.gameObject.GetComponent<Test_Value_MonoBehaviour>().jsonstring);
	}
}

