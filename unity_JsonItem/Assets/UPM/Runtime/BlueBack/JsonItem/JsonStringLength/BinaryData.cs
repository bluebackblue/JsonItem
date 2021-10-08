

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem.JsonStringLength
*/
namespace BlueBack.JsonItem.JsonStringLength
{
	/** バイナリデータ。
	*/
	public static class BinaryData
	{
		/** GetLength
		*/
		public static int GetLength(string a_jsonstring,int a_index,int a_length)
		{
			int t_index = a_index;

			if(t_index < a_length){
				if(a_jsonstring[t_index] == '<'){
					//開始。
					t_index++;
					while(t_index < a_length){
						#pragma warning disable 0162
						switch(a_jsonstring[t_index]){
						case '>':
							{
								//終端。
								return t_index - a_index + 1;
							}break;
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
						case 'a':
						case 'A':
						case 'b':
						case 'B':
						case 'c':
						case 'C':
						case 'd':
						case 'D':
						case 'e':
						case 'E':
						case 'f':
						case 'F':
							{
								//次へ。
								t_index++;
							}break;
						default:
							{
								//不明な文字。

								#if(DEF_BLUEBACK_JSONITEM_ASSERT)
								DebugTool.Assert(false);
								#endif

								return 0;
							}break;
						}
						#pragma warning restore
					}
				
					//終端前に範囲外。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return 0;
				}else{
					//バイナリデータ以外。

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

