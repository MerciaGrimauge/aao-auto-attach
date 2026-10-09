# AAO Auto Attach

使用するリポジトリとAPIは次のとおりです。このパッケージ自身には公開APIはありません。

## 使用するリポジトリとAPI

### MerciaGrimaugeのリポジトリ

| リポジトリ | 使用するAPI |
| --- | --- |
| [Unity Editor Event Handlers](https://github.com/MerciaGrimauge/unity-editor-event-handlers) | `EditorEvents.Subscribe<TEvent>`、`IEventHandler<TEvent>`、`HandlerContext<TEvent>.AddComponent<T>` |
| 同リポジトリのAvatar Placement Condition | `AvatarPlacement.Editor.AvatarPlaced` |

### 第三者のリポジトリ

| リポジトリ | 使用するAPI |
| --- | --- |
| [Avatar Optimizer](https://github.com/anatawa12/AvatarOptimizer) | `Anatawa12.AvatarOptimizer.TraceAndOptimize` |

## 動作

`AvatarPlaced`を受け取ると、配置されたアバターPrefabのルートにAAOのTrace And Optimizeを既定設定で追加します。すでに付いている場合は追加せず、既存の設定も変更しません。アバターの最適化をその場で実行する機能はありません。

追加したコンポーネントはシーン上のPrefabインスタンスに残ります。シーンの保存は利用者が行ってください。

## 導入

パッケージIDは `io.github.merciagrimauge.aao-auto-attach` です。VPMの依存関係として以下を宣言しています。

### MerciaGrimaugeのパッケージ

| パッケージ | 必要なバージョン |
| --- | --- |
| Editor Event Handlers | `^0.3.0` |
| Avatar Placement Condition | `^0.2.4` |

### 第三者のパッケージ

| パッケージ | 必要なバージョン |
| --- | --- |
| Avatar Optimizer | `>=1.9.20 <2.0.0` |

VRChat Avatars SDKが必要です。Avatar Optimizer、NDMFなどの導入・更新はALCOM等のパッケージ管理ツールで行ってください。

### 配布形式

[Release](https://github.com/MerciaGrimauge/aao-auto-attach/releases)にはVPM用ZIPと `.unitypackage` があります。ALCOM等で導入するには、対象パッケージがVPMリポジトリに登録され、依存パッケージも配布されている必要があります。`.unitypackage` はUnityのImport Packageから導入できますが、依存パッケージは別途導入してください。同じプロジェクトに両形式を重ねて導入しないでください。

## 対応範囲

Unity 2022.3向けです。Unity 6でのSDK・AAO連携、実際のAAO最適化結果、SDKアップロードは未検証です。

ライセンスは[MIT](LICENSE)です。本ソフトウェアは現状のまま提供します。SDKやAvatar Optimizerのコード・素材は同梱していません。
