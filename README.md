# MAVenRead
MAVenReadの開発

システムバージョン
* Unityのバージョン:2019.4.13f1
* WindowsSDKのバージョン:10.1.19041.1
* Vuforiaのバージョン：8.6.7
* MRTK:2.8.2.0


各シーンについて
## 共通の項目
本の大きさはA4サイズ、マーカーは55mm × 55mmのものを想定しています。
マーカーのデータベースは各々Vuforiaで登録して使用してください。
全部で10種類程マーカーを登録することで最低限システムを使用することができます。

## MAVenRead
テキストのフォントとサイズが変更できるスタンダードなMAVenReadのシーンです。
マーカは本の内側中央に設置してください。
ページ数は定義増減してください。
読む本のデータはTextObjectDataに保存されているます。本のテキストデータをTextObjectDataに追加し、マーカーとTextObjectDataの本のIDとを紐づけることで本を追加、変更することができます。

## XBooks
UI上にテキストを投影して本を読むMAVenReadシステムA,テキストが印刷された本を読むMAVenReadシステムB、投影されたテキストを読むMAVenReadシステムCが一つになっているシーン。
### MAVenReadシステムA
ボタンでページの移動、ウィンドウのオンオフができます。
実験用だったので、MAVenReadシステムAの本の種類を変えられるようにはなっていません。
### MAVenReadシステムB
印刷されたテキストの部分にファントムを表示するだけのシステムです。

### MAVenReadシステムC
MAVenReadのシーンと同じです。

## MAVenReadVerse
MAVenReadVerseの基本的なシーンで主にデモ用のシーンです。
詩の種類とテキストアニメーションをTestSceneChangeで、管理しています。
アニメーションはOneCharacterOnでタイプライタをそれ以外のアニメーションはTextMeshProGeometryAnimatorで管理しています。
アニメーションの基本的な仕様は
https://coposuke.hateblo.jp/entry/2020/06/07/020235

を参考にしてください。

## MAVenReadVerse_eyes
