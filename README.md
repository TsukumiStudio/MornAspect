# MornAspect

## 概要

画面解像度のアスペクト比に応じてカメラやUIを自動調整するライブラリ。

## 依存関係

| 種別 | 名前 |
|------|------|
| Mornライブラリ | MornGlobal |

## 使い方

### セットアップ

1. Projectウィンドウで右クリック → `Create > Morn/MornAspectGlobal` を作成
2. `Resolution` に目標解像度を設定（例: 1920x1080）

### コンポーネント

| コンポーネント | 対象 | 機能 |
|---------------|------|------|
| MornAspectCamera | Camera | カメラのビュー矩形を自動調整（レターボックス対応） |
| MornAspectCanvas | CanvasScaler | 参照解像度・スケールモード自動設定 |
| MornAspectFullScreenUI | RectTransform | フルスクリーンUIのサイズ調整 |
