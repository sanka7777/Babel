# バベル転生
チームで開発したオンライン対戦ゲームです。  
チーム構成  
sanka7777:企画/ネットワーク処理実装　
メンバー1:ゲームAI設計実装/NPC・Player設計実装
メンバー2:NPC・Player設計実装/システム詳細設計実装
メンバー3:ゲームルールシステム設計実装/レベルデザイン
メンバー4:システム詳細設計実装  

sanka7777担当・関与スクリプト:CharacterMaker.cs, Ready.cs,GameStart.cs, RoomConnect.cs, ButtonVisible.cs, GameEnd.cs, HostExplanation.cs, NetworkConnect.cs, NonHostExplanation.cs, 
RoomTimeManager.cs  

【動作環境】Windows10【使用言語】Unity/C#
【概要】オンライン対応入れ替わり式の非対称戦闘ゲームです。ゲーム開始時プレイヤーはランダムな動物に転生します。サメとなったプレイヤーは他プレイヤーを捕食し高得点を得る事ができます。草食動物となったプレイヤーはサメから逃げるかバベルの塔を建築することでポイントを得られます。塔を建てるとサメに転生できるため、より高得点を狙える最強生物サメへの転生を目指してください。時間内により高いポイントを稼いだプレイヤーが勝利します。
【操作方法】
ルーム選択：
ルーム1、ルーム2、ルーム3を選んでクリック。(ゲーム中のルームには入ることができません。)
待機ルーム：
初めに入室したプレイヤーがホストになります。任意のタイミングでホストがゲームスタートを押してください。足りないプレイヤーはNPCで自動的に補われます。
ゲーム:
W:前移動　A:左移動　S:下移動　D:右移動　マウス：カメラ移動
キルアクション(サメプレイヤー）：左クリック(キル後はバーが消えるまでクールタイム)
※同じ人を2連続キル不可
バベル(ステージの四隅にある円柱)建築(草食動物)：近くでスペースキーを押し続けると建築できる。100パーセントになるとサメに転生することができ、ゲーム中のほかのプレイヤーも違う生き物に転生。
アンチシャークフィールド(壁で囲まれたステージ2か所のフィールド)：プレイヤーがフィールド内でスペースキーを押すと起動。一定時間色が変化している間はフィールド内でサメの移動が遅くなる。
