

/** BlueBack.JsonItem.Samples.Inspector
*/
namespace BlueBack.JsonItem.Samples.Inspector
{
	/** Viewer_MonoBehaviour
	*/
	public sealed class Viewer_MonoBehaviour : BlueBack.JsonItem.InspectorViewer_MonoBehaviour
	{
		/** jsonstring
		*/
		public string jsonstring_1 = "{\"aiueo\":<E38182E38184E38186E38188E3818AE38182E38184E38186E38188E3818A>}";
		public string jsonstring_2 = "null";
		public string jsonstring_3 = "[[\"value\",{\"aaa\":\"xxx\",\"bbb\":{\"abc\":\"xyz\"}},3],-1,1,0.001f,true,null,-3m,\"x\"]";

		/** hash
		*/
		private int hash;

		/** Awake
		*/
		private void Awake()
		{
			#if(UNITY_EDITOR)
			{
				this.editor_view_list = new System.Collections.Generic.List<JsonItem>();
			}
			#endif
		}

		/** Update
		*/
		private void Update()
		{
			int t_hash_new = this.jsonstring_1.GetHashCode() ^ this.jsonstring_2.GetHashCode() ^ this.jsonstring_3.GetHashCode();
			if(this.hash != t_hash_new){
				this.hash = t_hash_new;

				#if(UNITY_EDITOR)
				{
					this.editor_view_list.Clear();
					this.editor_view_list.Add(new BlueBack.JsonItem.JsonItem(this.jsonstring_1));
					this.editor_view_list.Add(new BlueBack.JsonItem.JsonItem(this.jsonstring_2));
					this.editor_view_list.Add(new BlueBack.JsonItem.JsonItem(this.jsonstring_3));
				}
				#endif
			}
		}
	}
}

