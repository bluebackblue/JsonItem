

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 設定。
*/


/** Editor
*/
#if(UNITY_EDITOR)
namespace Editor
{
	/** UpmVersionManagerSetting
	*/
	[UnityEditor.InitializeOnLoad]
	public static class UpmVersionManagerSetting
	{
		/** UpmVersionManagerSetting
		*/
		static UpmVersionManagerSetting()
		{
			//Object_RootUssUxml
			BlueBack.UpmVersionManager.Editor.Object_RootUssUxml.CreateFile(false);

			BlueBack.UpmVersionManager.Editor.Object_Setting.CreateInstance();
			BlueBack.UpmVersionManager.Editor.Object_Setting.Param t_param = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param();
			{
				//author_name
				t_param.author_name = "BlueBack";

				//author_url
				t_param.git_url = "https://github.com/";

				//author_url
				t_param.git_author = "bluebackblue";

				//package_name
				t_param.package_name = "JsonItem";

				//getpackageversion
				t_param.getpackageversion = BlueBack.JsonItem.Version.GetPackageVersion;

				//packagejson_unity
				t_param.packagejson_unity = "2020.1";

				//packagejson_discription
				t_param.packagejson_discription = "JSON操作";

				//packagejson_keyword
				t_param.packagejson_keyword = new string[]{
					"json"
				};

				//packagejson_dependencies
				t_param.packagejson_dependencies = new System.Collections.Generic.Dictionary<string,string>();

				//asmdef_reference
				t_param.asmdef_reference = new string[]{
				};

				//editorasmdef_reference
				t_param.editorasmdef_reference = new string[]{
					"BlueBack.JsonItem",
				};

				//changelog
				t_param.changelog = new string[]{
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

				//readme_md
				t_param.object_root_readme_md = new BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Type[]{

					//概要。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"# " + a_argument.param.author_name + "." +  a_argument.param.package_name,
							"JSON操作",
							"* JSONのロード、セーブ",
							"* PrittyをNormalize",
							"* JSONをInspectorに表示",
						};
					},

					//ライセンス。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## ライセンス",
							"MIT License",
							"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + a_argument.param.package_name + "/blob/main/LICENSE",
						};
					},

					//依存。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 外部依存 / 使用ライセンス等",
							//"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + "AssetLib",
							"### サンプルのみ",
							"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + "AssetLib",
						};
					},

					//動作確認。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 動作確認",
							"Unity " + UnityEngine.Application.unityVersion,
						};
					},

					//UPM。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## UPM",
							"### 最新",
							"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + a_argument.param.package_name + ".git?path=unity_" + a_argument.param.package_name + "/Assets/UPM#" + a_argument.version,
							"### 開発",
							"* " + a_argument.param.git_url + a_argument.param.git_author + "/" + a_argument.param.package_name + ".git?path=unity_" + a_argument.param.package_name + "/Assets/UPM",
						};
					},

					//インストール。 
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
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

					//例。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
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

			BlueBack.UpmVersionManager.Editor.Object_Setting.GetInstance().Set(t_param);
		}
	}
}
#endif

