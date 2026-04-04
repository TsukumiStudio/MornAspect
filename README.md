# MornAspect

<p align="center">
  <img src="https://img.shields.io/github/license/TsukumiStudio/MornAspect" alt="License" />
</p>

## 概要

画面解像度のアスペクト比に応じてカメラやUIを自動調整するライブラリ。

## 導入方法

Unity Package Manager で以下の Git URL を追加:

```
https://github.com/TsukumiStudio/MornAspect.git?path=src#1.0.0
```

`Window > Package Manager > + > Add package from git URL...` に貼り付けてください。

### 依存パッケージ

- [MornGlobal](https://github.com/TsukumiStudio/MornGlobal) (`com.tsukumistudio.mornglobal`)

## 機能

| コンポーネント | 対象 | 機能 |
|---------------|------|------|
| `MornAspectCamera` | Camera | ビュー矩形を自動調整（レターボックス対応・拡大率設定可） |
| `MornAspectCanvas` | CanvasScaler | 参照解像度・スケールモード・マッチモードを自動設定 |
| `MornAspectFullScreenUI` | RectTransform | フルスクリーンUIのサイズを基準解像度に合わせて調整 |

## 使い方

1. Projectウィンドウで右クリック → `Create > Morn/MornAspectGlobal` を作成
2. `Resolution` に基準解像度を設定（例: 1920x1080）
3. 各GameObjectに必要なコンポーネントをアタッチ

## ライセンス

[The Unlicense](LICENSE)
