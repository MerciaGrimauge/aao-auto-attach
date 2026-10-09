# AAO Auto Attach

次のリポジトリとAPIを使用するUnity Editor拡張です。

## 使用するリポジトリとAPI

### MerciaGrimaugeのリポジトリ

- [Unity Editor Event Handlers](https://github.com/MerciaGrimauge/unity-editor-event-handlers): `EditorEvents.Subscribe<AvatarPlaced>`、`IEventHandler<AvatarPlaced>`、`HandlerContext<AvatarPlaced>.AddComponent<T>`、`AvatarPlaced`。

### 第三者のリポジトリ

- [Avatar Optimizer](https://github.com/anatawa12/AvatarOptimizer): `Anatawa12.AvatarOptimizer.TraceAndOptimize`。

## 動作と導入

新しく配置されたアバターPrefabのルートに、AAOのTrace And Optimizeを既定設定で追加します。すでに付いている場合は何も変更しません。アバターの最適化をその場で実行する機能はありません。

パッケージIDは `io.github.merciagrimauge.aao-auto-attach` です。導入方法、依存パッケージ、動作の説明は[パッケージREADME](Packages/io.github.merciagrimauge.aao-auto-attach/README.md)を参照してください。

Unity 2022.3向けです。Unity 6でのSDK・AAO連携は未検証です。

ライセンスは[MIT](LICENSE)です。本ソフトウェアは現状のまま提供します。SDKやAvatar Optimizerのコード・素材は同梱していません。
