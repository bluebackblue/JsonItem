# BlueBack.JsonItem
JSON操作
* JSONのロード、セーブ
* PrittyをNormalize
* JSONをInspectorに表示

## ライセンス
MIT License
* https://github.com/bluebackblue/JsonItem/blob/main/LICENSE

## 外部依存 / 使用ライセンス等
### サンプルのみ
* https://github.com/bluebackblue/AssetLib

## 動作確認
Unity 2020.2.0b14

## UPM
### 最新
* https://github.com/bluebackblue/JsonItem.git?path=unity_JsonItem/Assets/UPM#0.0.12
### 開発
* https://github.com/bluebackblue/JsonItem.git?path=unity_JsonItem/Assets/UPM

## Unityへの追加方法
* Unity起動
* メニュー選択：「Window->Package Manager」
* ボタン選択：「左上の＋ボタン」
* リスト選択：「Add package from git URL...」
* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」
### 注
Gitクライアントがインストールされている必要がある。
* https://docs.unity3d.com/ja/current/Manual/upm-git.html
* https://git-scm.com/

## 例
```
/** Item
*/
public struct Item
{
	public int x;
	public bool yy;
	public float zzz;
}
```
```
{
	//JsonItemにコンバート。
	BlueBack.JsonItem.JsonItem t_jsonitem = BlueBack.JsonItem.Convert.ObjectToJsonItem(t_from_item);

	//JSON文字列にコンバート。
	string t_jsonstring = t_jsonitem.ConvertToJsonString();
	UnityEngine.Debug.Log("ConvertToJsonString : " + t_jsonstring);

	//オブジェクトにコンバート。
	Item t_to_item = t_jsonitem.ConvertToObject<Item>();
	UnityEngine.Debug.Log("ConvertToObject : x = " + t_to_item.x.ToString());
	UnityEngine.Debug.Log("ConvertToObject : yy = " + t_to_item.yy.ToString());
	UnityEngine.Debug.Log("ConvertToObject : zzz = " + t_to_item.zzz.ToString());

	//JsonItemから直接取り出す。
	t_jsonitem = new BlueBack.JsonItem.JsonItem(t_jsonstring);
	UnityEngine.Debug.Log("JsonItem : x = " + t_jsonitem.GetItem("x").CastToInt32().ToString());
	UnityEngine.Debug.Log("JsonItem : yy = " + t_jsonitem.GetItem("yy").GetBoolData().ToString());
	UnityEngine.Debug.Log("JsonItem : zzz = " + t_jsonitem.GetItem("zzz").CastToSingle().ToString());
}
```

