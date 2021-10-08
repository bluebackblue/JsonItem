

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 属性。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** コンバート時に除外する。
	*/
	public sealed class Ignore : System.Attribute
	{
	}

	/** Enumを文字データとして出力する。
	*/
	public sealed class EnumString : System.Attribute
	{
	}

	/** Enumを数値として出力する。
	*/
	public sealed class EnumInt : System.Attribute
	{
	}
}

