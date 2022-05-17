

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief CustomEditor。
*/


/** BlueBack.JsonItem
*/
#if(UNITY_EDITOR)
namespace BlueBack.JsonItem.Editor
{
	/** JsonItem_CustomEditor
	*/
	[UnityEditor.CustomEditor(typeof(InspectorViewer_MonoBehaviour),true)]
	public sealed class JsonItem_CustomEditor : UnityEditor.Editor
	{
		/** expanded
		*/
		private System.Collections.Generic.Dictionary<string,bool> expanded;

		/** GetExpanded
		*/
		public bool GetExpanded(string a_address)
		{
			if(this.expanded == null){
				this.expanded = new System.Collections.Generic.Dictionary<string,bool>();
			}
		
			if(this.expanded.ContainsKey(a_address) == true){
				return this.expanded[a_address];
			}else{
				this.expanded[a_address] = false;
				return false;
			}
		}

		/** SetExpanded
		*/
		public bool SetExpanded(string a_address,bool a_flag)
		{
			if(this.expanded == null){
				this.expanded = new System.Collections.Generic.Dictionary<string,bool>();
			}
			this.expanded[a_address] = a_flag;
			return a_flag;
		}

		/**OnInspectorGUI
		*/
		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();

			InspectorViewer_MonoBehaviour t_this = this.target as InspectorViewer_MonoBehaviour;

			UnityEditor.EditorGUILayout.Space(18);

			{
				System.Collections.Generic.List<BlueBack.JsonItem.JsonItem> t_editor_view_list = t_this.editor_view_list;
				if(t_editor_view_list != null){
					for(int ii=0;ii<t_editor_view_list.Count;ii++){
						UnityEditor.EditorGUILayout.LabelField(t_editor_view_list[ii].ConvertToJsonString());
						this.Draw(0,null,ii.ToString(),t_editor_view_list[ii]);
						UnityEditor.EditorGUILayout.Space(18);
					}
				}
			}
		}

		/** Draw
		*/
		public void Draw(int a_nest,string a_name,string a_address,BlueBack.JsonItem.JsonItem a_jsonitem)
		{
			if(a_jsonitem == null){
				 UnityEditor.EditorGUILayout.LabelField("null");
			}else{
				switch(a_jsonitem.value.valuetype){
				case BlueBack.JsonItem.ValueType.Null:
					{
						if(a_name != null){
							UnityEditor.EditorGUILayout.LabelField(a_name + " : Null");
						}else{
							UnityEditor.EditorGUILayout.LabelField("Null");
						}
					}break;
				case BlueBack.JsonItem.ValueType.IndexArray:
					{
						System.Collections.Generic.List<BlueBack.JsonItem.JsonItem> t_list = a_jsonitem.GetIndexArray();

						string t_name;
						if(a_name != null){
							t_name = a_name + " : IndexArray(" + t_list.Count.ToString() + ")";
						}else{
							t_name = "IndexArray(" + t_list.Count.ToString() + ")";
						}

						if(this.SetExpanded(a_address,UnityEditor.EditorGUILayout.Foldout(this.GetExpanded(a_address),t_name)) == true){
							UnityEditor.EditorGUI.indentLevel++;

							for(int ii=0;ii<t_list.Count;ii++){
								this.Draw(a_nest + 1,null,a_address + "." + ii.ToString(),t_list[ii]);
							}

							UnityEditor.EditorGUI.indentLevel--;
						}
					}break;

				case BlueBack.JsonItem.ValueType.AssociativeArray:
					{
						System.Collections.Generic.Dictionary<string,BlueBack.JsonItem.JsonItem> t_list = a_jsonitem.GetAssociativeArray();

						string t_name;
						if(a_name != null){
							t_name = a_name + " : AssociativeArray(" + t_list.Count.ToString() + ")";
						}else{
							t_name = "AssociativeArray(" + t_list.Count.ToString() + ")";
						}

						if(this.SetExpanded(a_address,UnityEditor.EditorGUILayout.Foldout(this.GetExpanded(a_address),t_name)) == true){
							UnityEditor.EditorGUI.indentLevel++;

							foreach(System.Collections.Generic.KeyValuePair<string,BlueBack.JsonItem.JsonItem> t_pair in t_list){
								this.Draw(a_nest + 1,t_pair.Key,a_address + "." + t_pair.Key,t_pair.Value);
							}

							UnityEditor.EditorGUI.indentLevel--;
						}
					}break;
				case BlueBack.JsonItem.ValueType.BinaryData:
					{
						System.Collections.Generic.List<byte> t_list = a_jsonitem.GetBinaryData();

						string t_name;
						if(a_name != null){
							t_name = a_name + " : BinaryData(" + t_list.Count.ToString() + ")";
						}else{
							t_name = "BinaryData(" + t_list.Count.ToString() + ")";
						}

						if(this.SetExpanded(a_address,UnityEditor.EditorGUILayout.Foldout(this.GetExpanded(a_address),t_name)) == true){
							UnityEditor.EditorGUI.indentLevel++;
							System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder(32);

							int t_index=0;
							while(t_index<t_list.Count){
								t_stringbuilder.Clear();
								for(int ii=t_index;((ii<t_list.Count)&&(ii<t_index + 16));ii++){
									t_stringbuilder.Append(t_list[ii].ToString("X2"));
									t_stringbuilder.Append(" ");
								}
								UnityEditor.EditorGUILayout.LabelField(t_stringbuilder.ToString());
								t_index += 16;
							}

							UnityEditor.EditorGUI.indentLevel--;
						}
					}break;
				case BlueBack.JsonItem.ValueType.StringData:
					{
						if(a_name != null){
							UnityEditor.EditorGUILayout.LabelField(a_name + " : StringData",a_jsonitem.GetStringData());
						}else{
							UnityEditor.EditorGUILayout.LabelField("StringData",a_jsonitem.GetStringData());
						}
					}break;
				case BlueBack.JsonItem.ValueType.SignedNumber:
					{
						if(a_name != null){
							UnityEditor.EditorGUILayout.LabelField(a_name + " : SignedNumber",a_jsonitem.GetSignedNumber().ToString());
						}else{
							UnityEditor.EditorGUILayout.LabelField("SignedNumber",a_jsonitem.GetSignedNumber().ToString());
						}
					}break;
				case BlueBack.JsonItem.ValueType.UnsignedNumber:
					{
						if(a_name != null){
							UnityEditor.EditorGUILayout.LabelField(a_name + " : UnsignedNumber",a_jsonitem.GetUnsignedNumber().ToString());
						}else{
							UnityEditor.EditorGUILayout.LabelField("UnsignedNumber",a_jsonitem.GetUnsignedNumber().ToString());
						}
					}break;
				case BlueBack.JsonItem.ValueType.FloatingNumber:
					{
						if(a_name != null){
							UnityEditor.EditorGUILayout.LabelField(a_name + " : FloatingNumber",a_jsonitem.GetFloatingNumber().ToString());
						}else{
							UnityEditor.EditorGUILayout.LabelField("FloatingNumber",a_jsonitem.GetFloatingNumber().ToString());
						}
					}break;
				case BlueBack.JsonItem.ValueType.BoolData:
					{
						if(a_name != null){
							UnityEditor.EditorGUILayout.LabelField(a_name + " : BoolData",a_jsonitem.GetBoolData().ToString());
						}else{
							UnityEditor.EditorGUILayout.LabelField("BoolData",a_jsonitem.GetBoolData().ToString());
						}
					}break;
				case BlueBack.JsonItem.ValueType.DecimalNumber:
					{
						if(a_name != null){
							UnityEditor.EditorGUILayout.LabelField(a_name + " : DecimalNumber",a_jsonitem.GetDecimalNumber().ToString());
						}else{
							UnityEditor.EditorGUILayout.LabelField("DecimalNumber",a_jsonitem.GetDecimalNumber().ToString());
						}
					}break;
				}
			}
		}
	}
}
#endif

