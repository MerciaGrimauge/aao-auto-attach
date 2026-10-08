# AAO Auto Attach

`AvatarPlaced`を購読し、新しく配置されたアバターPrefabのルートにAAO Trace And Optimizeを既定設定で追加するUnity Editor拡張です。

このパッケージ自身にpublic型や登録用APIはありません。内部の購読は `IEventHandler<AvatarPlaced>` を実装します。独自の購読を作る場合は[共通API reference](https://github.com/MerciaGrimauge/unity-editor-event-handlers/blob/main/Packages/io.github.merciagrimauge.editor-event-handlers/Documentation~/API_REFERENCE.md)と[実装例](https://github.com/MerciaGrimauge/unity-editor-event-handlers/blob/main/Packages/io.github.merciagrimauge.editor-event-handlers/Documentation~/HANDLER_AUTHORING.md)を参照してください。

## 動作

検知はAvatar Placement Condition、実行・復元はEditor Event Handlersが担当します。AAO拡張がUnityイベントやDescriptorを個別に監視する処理はありません。

購読IDは `io.github.merciagrimauge.aao-auto-attach.trace-and-optimize`です。実行順は公開契約に含まれません。制限時間の初期値・上限は100 msで、他の条件・購読と独立しています。管理ウィンドウでハンドラを有効・無効にし、制限時間を1〜100 msに設定できます。既存AAOがある場合は設定を変更せずSkipします。既存AAOは他の購読者の実行を妨げません。新規追加はシーン上の追加Component Overrideとして残り、保存は利用者が行います。

自動追加は独立したUndo操作です。手動削除、Undo/Redo、シーン再読込、再コンパイルを契機とした一括追加はしません。失敗・期限超過時は共通管理が変更を復元し、この購読を無効化し、異常記録はEditor再起動後にも保持します。再有効化は管理ウィンドウから行います。

## 必要なパッケージ

VPMの依存関係はEditor Event Handlers、Avatar Placement Condition、Avatar Optimizer（1.9.20以上・2.0.0未満）です。ALCOM等のパッケージ管理ツールが依存を解決します。VRChat Avatars SDK、Avatar Optimizer、NDMFの導入・更新はパッケージ管理ツールまたは利用者が行い、この拡張の実行コードでは取得・更新しません。

AAOの公式Component APIで公開されているTraceAndOptimize型を直接参照し、既定設定で追加します。AAOの型検索・非公開設定へのアクセスは行いません。コンパイルにはAAOが必要です。SDKがなければ共通側の配置条件が登録されず待機します。

作成通知はユーザー入力の発生元を証明しないため、Undo登録された他ツールによる新規配置も対象になり得ます。停止・復元の契約は[共通ライブラリ](https://github.com/MerciaGrimauge/unity-editor-event-handlers/blob/main/Packages/io.github.merciagrimauge.editor-event-handlers/README.md)を参照してください。

Unity 2022.3向けです。共通ライブラリのUnity識別子互換層とは別に、SDK・AAO・NDMFのUnity 6互換性を確認する必要があります。Unity 6でのSDK連携、実際のAAO最適化結果、SDKアップロード、GUI入力から画面反映までの総遅延は未検証です。ライセンスはMITです。本ソフトウェアは現状のまま提供します。[LICENSE](LICENSE)を参照してください。
