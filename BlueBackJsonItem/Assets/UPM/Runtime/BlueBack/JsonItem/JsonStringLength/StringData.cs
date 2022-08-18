

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.JsonStringLength
*/
namespace BlueBack.JsonItem.JsonStringLength
{
	/** 文字データ。
	*/
	public static class StringData
	{
		/** GetLength
		*/
		public static int GetLength(string a_jsonstring,int a_index,int a_length)
		{
			int t_index = a_index;

			if(t_index < a_length){
				if((a_jsonstring[t_index] == '"')||(a_jsonstring[t_index] == '\'')){
					//開始。
					t_index++;
					while(t_index < a_length){
						#pragma warning disable 0162
						switch(a_jsonstring[t_index]){
						case '"':
						case '\'':
							{
								//終端。
								return t_index - a_index + 1;
							}break;
						case '\\':
							{
								//２文字構成。
								if((t_index + 1) < a_length){
									t_index += 2;
								}else{
									//「\\」の後ろが範囲外。

									#if(DEF_BLUEBACK_DEBUG_ASSERT)
									DebugTool.Assert(false,string.Format("index = {0} : char = {1} : {2}",t_index,a_jsonstring[t_index],a_jsonstring));
									#endif

									return 0;
								}
							}break;
						default:
							{
								//１文字。
								t_index++;
							}break;
						}
						#pragma warning restore
					}

					//終端前に範囲外。

					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("index = {0} : char = {1} : {2}",t_index,a_jsonstring[t_index],a_jsonstring));
					#endif

					return 0;
				}else{
					//文字列以外。

					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("index = {0} : char = {1} : {2}",t_index,a_jsonstring[t_index],a_jsonstring));
					#endif

					return 0;
				}
			}else{
				//開始位置が範囲外。

				#if(DEF_BLUEBACK_DEBUG_ASSERT)
				DebugTool.Assert(false,string.Format("index = {0} : char = {1} : {2}",t_index,a_jsonstring[t_index],a_jsonstring));
				#endif

				return 0;
			}
		}
	}
}

