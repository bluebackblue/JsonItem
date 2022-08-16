

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** インデックス配列 ==> Json文字列。
	*/
	public static class IndexArray
	{
		/** Convert
		*/
		public static void Convert(System.Collections.Generic.List<JsonItem> a_in_list,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			{
				a_out_stringbuilder.Append("[");

				{
					if(a_in_list != null){
						int t_count = a_in_list.Count;
						int t_index = 0;

						if(t_count > 0){

							//一つ目。
							if(a_in_list[0] != null){
								a_in_list[0].ValueToJsonString(a_out_stringbuilder,a_option);
							}else{
								//NULL処理。
								a_out_stringbuilder.Append("null");
							}

							//二つ目以降。
							t_index++;
							for(;t_index<t_count;t_index++){
								a_out_stringbuilder.Append(",");
								if(a_in_list[t_index] != null){
									a_in_list[t_index].ValueToJsonString(a_out_stringbuilder,a_option);
								}else{
									//NULL処理。
									a_out_stringbuilder.Append("null");
								}
							}
						}
					}else{

						#if(DEF_BLUEBACK_DEBUG_ASSERT)
						DebugTool.Assert(false);
						#endif

					}
				}

				a_out_stringbuilder.Append("]");
				return;
			}
		}
	}
}

