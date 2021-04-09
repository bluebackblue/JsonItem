

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem.JsonStringLength
*/
namespace BlueBack.JsonItem.JsonStringLength
{
	/** 連想配列。
	*/
	public class AssociateArray
	{
		/** GetLength
		*/
		public static int GetLength(string a_jsonstring,int a_index,int a_length)
		{
			int t_index = a_index;

			if(t_index < a_length){
				if(a_jsonstring[t_index] == '{'){
					//開始。
					t_index++;
					int t_nest = 0;
					while(t_index < a_length){
						switch(a_jsonstring[t_index]){
						case '}':
							{
								if(t_nest <= 0){
									//終端。
									return t_index - a_index + 1;
								}else{
									//ネスト。
									t_nest--;
									t_index++;
								}
							}break;
						case '{':
							{
								//ネスト。
								t_nest++;
								t_index++;
							}break;
						case '"':
						case '\'':
							{
								//文字列。
								int t_add = StringData.GetLength(a_jsonstring,t_index,a_length);
								if(t_add > 0){
									t_index += t_add;
								}else{
									//文字サイズの取得に失敗。

									#if(DEF_BLUEBACK_JSONITEM_ASSERT)
									DebugTool.Assert(false);
									#endif

									return 0;
								}
							}break;
						default:
							{
								//次へ。
								t_index++;
							}break;
						}
					}
				
					//終端前に範囲外。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return 0;
				}else{
					//連想配列以外。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return 0;
				}
			}else{
				//開始位置が範囲外。

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(false);
				#endif

				return 0;
			}
		}
	}
}

