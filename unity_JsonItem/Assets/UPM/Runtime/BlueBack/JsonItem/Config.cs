

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンフィグ。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** Config
	*/
	public class Config
	{
		/** ERRORPROC
		*/
		private static void Error()
		{
			UnityEngine.Debug.Assert(false);
		}
		public delegate void ErrorProcType();
		public static ErrorProcType ERRORPROC = Error;

		/** プール数。最大値。
		*/
		public static int POOL_MAX = 1024;

		/** コンバートネスト。最大値。
		*/
		public static int CONVERTNEST_MAX = 32;

		/** CULTURE
		*/
		public static System.IFormatProvider CULTURE = System.Globalization.CultureInfo.CreateSpecificCulture("ja-JP");

		/** Floating To String
		*/
		public static string FLOATING_TO_STRING_FORMAT = "{0:e16}";

		/** FLOATING_SEPARATOR
		*/
		public static char FLOATING_SEPARATOR = '.';

		/** デフォルトオプション。
		*/
		public static ConvertToJsonStringOption DEFAULT_CONVERTTOJSONSTRING_OPTION = ConvertToJsonStringOption.None;

		/** デフォルトオプション。
		*/
		public static ConvertToJsonItemOption DEFAULT_CONVERTTOJSONITEM_OPTION = ConvertToJsonItemOption.None;
	}
}

