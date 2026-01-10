# MornAspect

カメラやUIのアスペクト比を自動調整するライブラリ

## 依存関係

- MornGlobal

## セットアップ

1. `Project`を右クリック → `Morn/MornAspectGlobal`を作成
2. `Resolution`に目標解像度を設定（例: 1920x1080）

## コンポーネント

| コンポーネント                  | 対象            | 機能                |
|--------------------------|---------------|-------------------|
| `MornAspectCamera`       | Camera        | レターボックス対応、スケール調整  |
| `MornAspectCanvas`       | CanvasScaler  | 参照解像度・スケールモード自動設定 |
| `MornAspectFullScreenUI` | RectTransform | フルスクリーンUIのサイズ調整   |
