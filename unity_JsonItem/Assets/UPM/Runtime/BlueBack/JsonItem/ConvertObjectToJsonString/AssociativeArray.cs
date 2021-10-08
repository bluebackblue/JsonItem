

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** 連想配列 ==> Json文字列。
	*/
	public static class AssociativeArray
	{
		/** Convert
		*/
		public static void Convert(System.Collections.Generic.Dictionary<string,JsonItem> a_in_list,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			{
				a_out_stringbuilder.Append("{");

				{
					if(a_in_list != null){
						bool t_first = true;
						foreach(System.Collections.Generic.KeyValuePair<string,JsonItem> t_pair in a_in_list){
							if(t_first == true){
								//一つ目。

								if(t_pair.Value != null){
									t_first = false;
									a_out_stringbuilder.Append("\"");
									a_out_stringbuilder.Append(t_pair.Key);
									a_out_stringbuilder.Append("\":");
									t_pair.Value.ValueToJsonString(a_out_stringbuilder,a_option);
								}else{
									//NULL処理。
									t_first = false;
									a_out_stringbuilder.Append("\"");
									a_out_stringbuilder.Append(t_pair.Key);
									a_out_stringbuilder.Append("\":null");
								}
							}else{
								//二つ目以降。

								if(t_pair.Value != null){
									a_out_stringbuilder.Append(",\"");
									a_out_stringbuilder.Append(t_pair.Key);
									a_out_stringbuilder.Append("\":");
									t_pair.Value.ValueToJsonString(a_out_stringbuilder,a_option);
								}else{
									//NULL処理。
									a_out_stringbuilder.Append(",\"");
									a_out_stringbuilder.Append(t_pair.Key);
									a_out_stringbuilder.Append("\":null");
								}
							}
						}
					}else{
						#if(DEF_BLUEBACK_JSONITEM_ASSERT)
						DebugTool.Assert(false);
						#endif
					}
				}

				a_out_stringbuilder.Append("}");
				return;
			}
		}
	}
}

