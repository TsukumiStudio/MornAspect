using UnityEngine;
using UnityEngine.UI;

namespace MornLib
{
    [RequireComponent(typeof(CanvasScaler))]
    internal sealed class MornAspectCanvas : MornAspectComponentBase
    {
        [SerializeField, Tooltip("コンテンツ(null可)")] private RectTransform _contents;
        private CanvasScaler _canvasScaler;

        protected override void AdjustAspect()
        {
            if (!TryGetGlobal(out var global)) return;
            if (_canvasScaler == null) _canvasScaler = GetComponent<CanvasScaler>();
            if (_canvasScaler.uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize)
            {
                _canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                MornAspectGlobal.LogAndSetDirty("ScaleMode変更", _canvasScaler);
            }

            if (_canvasScaler.referenceResolution != global.Resolution)
            {
                _canvasScaler.referenceResolution = global.Resolution;
                MornAspectGlobal.LogAndSetDirty("Resolutionのサイズ変更", _canvasScaler);
            }

            if (_canvasScaler.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
            {
                _canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                MornAspectGlobal.LogAndSetDirty("ScreenMatchMode変更", _canvasScaler);
            }

            if (_contents != null && _contents.sizeDelta != global.Resolution)
            {
                _contents.sizeDelta = global.Resolution;
                MornAspectGlobal.LogAndSetDirty("Contentsのサイズ変更", _contents);
            }
        }
    }
}