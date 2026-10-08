# AAO Auto Attach

新しく配置されたアバターPrefabのルートに、AAO Trace And Optimizeを既定設定で付与するUnity Editor拡張です。検知とハンドラ管理は[Unity Editor Event Handlers](https://github.com/MerciaGrimauge/unity-editor-event-handlers)を使用します。

配布パッケージは `io.github.merciagrimauge.aao-auto-attach` 0.1.3です。VPMの依存としてEditor Event Handlers、Avatar Placement Condition、Avatar Optimizer（1.9.20以上・2.0.0未満）を宣言します。導入と依存解決はALCOM等のパッケージ管理ツールで行います。

AAOの公式Component APIの公開型を直接参照します。既存AAOの設定は変更しません。

詳しい動作・必要なパッケージは[パッケージREADME](Packages/io.github.merciagrimauge.aao-auto-attach/README.md)を参照してください。

Unity 2022.3向けです。共通ライブラリの識別子互換層とは別に、SDK・AAO・NDMFのUnity 6互換性を確認する必要があります。Unity 6でのSDK連携と実際の最適化・アップロードは未検証です。制御を返さないハンドラを強制終了する仕組みはありません。

MIT。本ソフトウェアは現状のまま提供します。ライセンス条件はLICENSEを参照してください。パッケージにもLICENSEを同梱しています。SDKやAvatar Optimizerのコード・素材は同梱していません。
