

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.JsonStringLength
*/
namespace BlueBack.JsonItem.JsonStringLength
{
	/** 数値。
	*/
	public static class Number
	{
		/** GetLength
		*/
		public static int GetLength(string a_string,int a_index,int a_length)
		{
			if(a_index < a_length){
				int t_index = a_index;

				#pragma warning disable 0162
				while(t_index < a_length){
					switch(a_string[t_index]){
					case '}':
					case ']':
					case ',':
					case ' ':
					case '\n':
					case '\t':
					case '\r':
						{
							//終端。
							return t_index - a_index;
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
					case '.':
					case '+':
					case '-':
					case 'e':
					case 'E':
					case 'm':
					case 'M':
					case 'f':
					case 'F':
					case 'l':
					case 'L':
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
				}
				#pragma warning restore

				//終端。
				return t_index - a_index;
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

