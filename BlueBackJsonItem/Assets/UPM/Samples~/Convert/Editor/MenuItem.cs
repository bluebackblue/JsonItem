

/** BlueBack.JsonItem.Samples.Convert.Editor
*/
#if(!DEF_BLUEBACK_JSONITEM_SAMPLES_DISABLE)
namespace BlueBack.JsonItem.Samples.Convert.Editor
{
	/** MenuItem
	*/
	#if(UNITY_EDITOR)
	public class MenuItem
	{
		/** E
		*/
		private enum E
		{
			A,
			B,
			C
		}

		/** Item
		*/
		private struct Item
		{
			public int x;
			public bool yy;
			public float zzz;

			[BlueBack.JsonItem.EnumString]
			public E e1;

			[BlueBack.JsonItem.EnumInt]
			public E e2;
		}

		/** JsonItemToObject
		*/
		[UnityEditor.MenuItem("Samples/BlueBack.JsonItem/Convert/JsonItemToObject")]
		private static void MenuItem_Test()
		{
			Item t_from_item = new Item()
			{
				x = 100,
				yy = true,
				zzz = 99.99f,
				e1 = E.A,
				e2 = E.B,
			};

			//JsonItemにコンバート。
			BlueBack.JsonItem.JsonItem t_jsonitem = BlueBack.JsonItem.Convert.ObjectToJsonItem(t_from_item);

			//JSON文字列にコンバート。
			string t_jsonstring = t_jsonitem.ConvertToJsonString();
			UnityEngine.Debug.Log("ConvertToJsonString : " + t_jsonstring);

			//オブジェクトにコンバート。
			Item t_to_item = BlueBack.JsonItem.Convert.JsonItemToObject<Item>(t_jsonitem);
			UnityEngine.Debug.Log("ConvertToObject : x = " + t_to_item.x.ToString());
			UnityEngine.Debug.Log("ConvertToObject : yy = " + t_to_item.yy.ToString());
			UnityEngine.Debug.Log("ConvertToObject : zzz = " + t_to_item.zzz.ToString());
			UnityEngine.Debug.Log("ConvertToObject : e1 = " + t_to_item.e1.ToString());
			UnityEngine.Debug.Log("ConvertToObject : e2 = " + t_to_item.e2.ToString());

			//JsonItemから直接取り出す。
			t_jsonitem = new BlueBack.JsonItem.JsonItem(t_jsonstring);
			UnityEngine.Debug.Log("JsonItem : x = " + t_jsonitem.GetItem("x").CastToInt32().ToString());
			UnityEngine.Debug.Log("JsonItem : yy = " + t_jsonitem.GetItem("yy").GetBoolData().ToString());
			UnityEngine.Debug.Log("JsonItem : zzz = " + t_jsonitem.GetItem("zzz").CastToSingle().ToString());
			UnityEngine.Debug.Log("JsonItem : e1 = " + t_jsonitem.GetItem("e1").GetStringData());
			UnityEngine.Debug.Log("JsonItem : e2 = " + t_jsonitem.GetItem("e2").CastToInt32().ToString());

			E t_e2 = BlueBack.JsonItem.Convert.JsonItemToObject<E>(t_jsonitem.GetItem("e2"));
			UnityEngine.Debug.Log("Direct : e2 = " + t_e2.ToString());
		}

		/** Normalize
		*/
		[UnityEditor.MenuItem("Samples/BlueBack.JsonItem/Convert/Normalize")]
		private static void MenuItem_Normalize()
		{
			string t_jsonstring_raw = BlueBack.AssetLib.LoadTextWithUrl.LoadNoBomUtf8("https://api.github.com/repos/bluebackblue/AssetLib/tags",null);
			UnityEngine.Debug.Log(t_jsonstring_raw);

			//空白、タブ、改行を省く。
			string t_jsonstring_normalize = BlueBack.JsonItem.Normalize.Convert(t_jsonstring_raw);
			UnityEngine.Debug.Log(t_jsonstring_normalize);

			//整形。
			string t_jsonstring_pretty = BlueBack.JsonItem.Pretty.Convert(t_jsonstring_normalize,"\t");
			UnityEngine.Debug.Log(t_jsonstring_pretty);

			BlueBack.JsonItem.JsonItem t_jsonitem = new BlueBack.JsonItem.JsonItem(t_jsonstring_normalize);

			int ii_max = t_jsonitem.GetListMax();
			for(int ii=0;ii<ii_max;ii++){
				UnityEngine.Debug.Log(t_jsonitem.GetItem(ii).GetItem("name").GetStringData());
			}
		}
	}
	#endif
}
#endif

