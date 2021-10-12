# BlueBack.JsonItem
JSON操作
* JSONのロード、セーブ
* PrittyをNormalize
* JSONをInspectorに表示

## ライセンス
MIT License
* https://github.com/bluebackblue/UpmJsonItem/blob/main/LICENSE

## 依存 / 使用ライセンス等
### ランタイム
### エディター
* https://github.com/bluebackblue/UpmJsonItem
### サンプル
* https://github.com/bluebackblue/UpmAssetLib
* https://github.com/bluebackblue/UpmJsonItem

## 動作確認
Unity 2021.1.11f1

## UPM
### 最新
* https://github.com/bluebackblue/UpmJsonItem.git?path=BlueBackJsonItem/Assets/UPM#0.0.24
### 開発
* https://github.com/bluebackblue/UpmJsonItem.git?path=BlueBackJsonItem/Assets/UPM

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
```cs
public struct Item
{
	public int x;
	public int yy;
	public float zzz;
};
```
```cs
{
	Item t_from_item = new Item(){
		x = 10,
		yy = 11,
		zzz = 123.4f,
	};
	
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

