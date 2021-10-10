

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 文字コンバート。
*/


/** BlueBack.JsonItem.StringConvertTool
*/
namespace BlueBack.JsonItem.StringConvertTool
{
	/** JsonItem用エスケープ文字列 ==> 特殊文字。

		"\\n" ==> "\n"

	*/
	public static class EscapeCodeStringToSpecialString
	{
		/** Convert
		*/
		public static bool Convert(char a_char,out char a_out_char)
		{
			#pragma warning disable 0162
			switch(a_char){
			case '\\':
				{
					//バックスラッシュ。
					a_out_char = a_char;
					return true;
				}break;
			case '\"':
				{
					//ダブルクォーテーション。
					a_out_char = a_char;
					return true;
				}break;
			case 'n':
				{
					//キャリッジリターン。
					a_out_char = '\n';
					return true;
				}break;
			case '0':
				{
					//ヌル。
					a_out_char = '\0';
					return true;
				}break;
			case '\'':
				{
					//シングルクォーテーション。
					a_out_char = a_char;
					return true;
				}break;
			case '/':
				{
					//スラッシュ。
					a_out_char = a_char;
					return true;
				}break;
			case 'b':
				{
					//バックスペース。
					a_out_char = '\b';
					return true;
				}break;
			case 'f':
				{
					//ニューページ。
					a_out_char = '\f';
					return true;
				}break;
			case 'r':
				{
					//ラインフィード。
					a_out_char = '\r';
					return true;
				}break;
			case 't':
				{
					//タブ。
					a_out_char = '\t';
					return true;
				}break;
			default:
				{
					//失敗。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					a_out_char = a_char;
					return false;
				}break;
			}
			#pragma warning restore
		}

		/** Convert

			return : 使用文字数。

		*/
		public static int Convert(string a_string,int a_offset,System.Text.StringBuilder a_stringbuilder)
		{
			#pragma warning disable 0162
			switch(a_string[a_offset]){
			case '\\':
				{
					//バックスラッシュ。
					a_stringbuilder.Append(a_string[a_offset]);
					return 1;
				}break;
			case '\"':
				{
					//ダブルクォーテーション。
					a_stringbuilder.Append(a_string[a_offset]);
					return 1;
				}break;
			case 'n':
				{
					//キャリッジリターン。
					a_stringbuilder.Append('\n');
					return 1;
				}break;
			case '0':
				{
					//ヌル。
					a_stringbuilder.Append('\0');
					return 1;
				}break;
			case '\'':
				{
					//シングルクォーテーション。
					a_stringbuilder.Append(a_string[a_offset]);
					return 1;
				}break;
			case '/':
				{
					//スラッシュ。
					a_stringbuilder.Append(a_string[a_offset]);
					return 1;
				}break;
			case 'b':
				{
					//バックスペース。
					a_stringbuilder.Append('\b');
					return 1;
				}break;
			case 'f':
				{
					//ニューページ。
					a_stringbuilder.Append('\f');
					return 1;
				}break;
			case 'r':
				{
					//ラインフィード。
					a_stringbuilder.Append('\r');
					return 1;
				}break;
			case 't':
				{
					//タブ。
					a_stringbuilder.Append('\t');
					return 1;
				}break;
			case 'u':
				{
					//ＵＴＦ１６。
					if((a_offset + 4) < a_string.Length){
						char t_char = StringConvertTool.Utf16CodeStringToChar.Convert_NoCheck(a_string,a_offset + 1);
						a_stringbuilder.Append(t_char);
						return 5;
					}else{
						//失敗。

						#if(DEF_BLUEBACK_JSONITEM_ASSERT)
						DebugTool.Assert(false);
						#endif

						return 0;
					}
				}break;
			default:
				{
					//失敗。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return 0;
				}break;
			}
			#pragma warning restore
		}
	}
}

