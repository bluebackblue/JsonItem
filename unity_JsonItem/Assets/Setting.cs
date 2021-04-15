

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 設定。
*/


/** Setting
*/
public class Setting
{
	/** AUTHOR_NAME
	*/
	public const string AUTHOR_NAME = "BlueBack";

	/** AUTHOR_URL
	*/
	public const string AUTHOR_URL = "https://github.com/bluebackblue";

	/** PACKAGE_NAME
	*/
	public const string PACKAGE_NAME = "JsonItem";

	/** PACKAGEJSON
	*/
	public const string PACKAGEJSON_UNITY = "2020.1";

	/** PACKAGEJSON
	*/
	public const string PACKAGEJSON_DISCRIPTION = "JSON操作";

	/** PACKAGEJSON
	*/
	public static readonly string[] PACKAGEJSON_KEYWORD = new string[]{
		"json"
	};

	/** CHANGELOG
	*/
	public static string[] CHANGELOG = new string[]{
		"# Changelog",
		"",

		/*
		"## [0.0.0] - 0000-00-00",
		"### Changes",
		"- Init",
		"",
		*/

		"## [0.0.1] - 2021-03-29",
		"### Changes",
		"- Init",
		"",
	};

	/** GetPackageVersion
	*/
	public static string GetPackageVersion()
	{
		return BlueBack.JsonItem.Version.packageversion;
	}

	/** ReadmeMd_StringCreator_Argument
	*/
	public struct ReadmeMd_StringCreator_Argument
	{
		public string version;
	}

	/** ReadmeMd_StringCreator_Type
	*/
	public delegate string[] ReadmeMd_StringCreator_Type(in ReadmeMd_StringCreator_Argument a_argument);

	/** READMEMD_STRINGCREATOR
	*/
	public static readonly ReadmeMd_StringCreator_Type[] READMEMD_STRINGCREATOR = new ReadmeMd_StringCreator_Type[]{

		/** 概要。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"# " + AUTHOR_NAME + "." + PACKAGE_NAME,
				"JSON操作",
				"* JSONのロード、セーブ",
				"* PrittyをNormalize",
				"* JSONをInspectorに表示",
			};
		},

		/** ライセンス。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## ライセンス",
				"MIT License",
				"* " + AUTHOR_URL + "/" + PACKAGE_NAME + "/blob/main/LICENSE",
			};
		},

		/** 依存。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## 外部依存 / 使用ライセンス等",
				//"* " + AUTHOR_URL + "/" + "AssetLib",
				"### サンプルのみ",
				"* " + AUTHOR_URL + "/" + "AssetLib",
			};
		},

		/** 動作確認。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## 動作確認",
				"Unity " + UnityEngine.Application.unityVersion,
			};
		},

		/** UPM。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## UPM",
				"### 最新",
				"* " + AUTHOR_URL + "/" + PACKAGE_NAME + ".git?path=unity_" + PACKAGE_NAME + "/Assets/UPM#" + a_argument.version,
				"### 開発",
				"* " + AUTHOR_URL + "/" + PACKAGE_NAME + ".git?path=unity_" + PACKAGE_NAME + "/Assets/UPM",
			};
		},

		/** インストール。 
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## Unityへの追加方法",
				"* Unity起動",
				"* メニュー選択：「Window->Package Manager」",
				"* ボタン選択：「左上の＋ボタン」",
				"* リスト選択：「Add package from git URL...」",
				"* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」",
				"### 注",
				"Gitクライアントがインストールされている必要がある。",
				"* https://docs.unity3d.com/ja/current/Manual/upm-git.html",
				"* https://git-scm.com/",
			};
		},

		/** 例。
		*/
		(in ReadmeMd_StringCreator_Argument a_argument) => {
			return new string[]{
				"## 例",

				"```",
				"/** Item",
				"*/",
				"public struct Item",
				"{",
				"	public int x;",
				"	public bool yy;",
				"	public float zzz;",
				"}",
				"```",

				"```",
				"{",
				"	//JsonItemにコンバート。",
				"	BlueBack.JsonItem.JsonItem t_jsonitem = BlueBack.JsonItem.Convert.ObjectToJsonItem(t_from_item);",
				"",
				"	//JSON文字列にコンバート。",
				"	string t_jsonstring = t_jsonitem.ConvertToJsonString();",
				"	UnityEngine.Debug.Log(\"ConvertToJsonString : \" + t_jsonstring);",
				"",
				"	//オブジェクトにコンバート。",
				"	Item t_to_item = t_jsonitem.ConvertToObject<Item>();",
				"	UnityEngine.Debug.Log(\"ConvertToObject : x = \" + t_to_item.x.ToString());",
				"	UnityEngine.Debug.Log(\"ConvertToObject : yy = \" + t_to_item.yy.ToString());",
				"	UnityEngine.Debug.Log(\"ConvertToObject : zzz = \" + t_to_item.zzz.ToString());",
				"",
				"	//JsonItemから直接取り出す。",
				"	t_jsonitem = new BlueBack.JsonItem.JsonItem(t_jsonstring);",
				"	UnityEngine.Debug.Log(\"JsonItem : x = \" + t_jsonitem.GetItem(\"x\").CastToInt32().ToString());",
				"	UnityEngine.Debug.Log(\"JsonItem : yy = \" + t_jsonitem.GetItem(\"yy\").GetBoolData().ToString());",
				"	UnityEngine.Debug.Log(\"JsonItem : zzz = \" + t_jsonitem.GetItem(\"zzz\").CastToSingle().ToString());",
				"}",
				"```",
			};
		},
	};
}

