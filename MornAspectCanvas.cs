using UnityEngine;
using UnityEngine.UI;

namespace MornLib
{
    [RequireComponent(typeof(CanvasScaler))]
    internal sealed class MornAspectCanvas : MornAspectComponentBase
    {
        private CanvasScaler _canvasScaler;

        protected override void AdjustAspect()
        {
            if (!TryGetGlobal(out var global)) return;
            if (_canvasScaler == null) _canvasScaler = GetComponent<CanvasScaler>();
            if (_canvasScaler.uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize)
            {
                _canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                MornAspectGlobal.Logger.Log("ScaleMode変更");
                MornAspectGlobal.SetDirty(_canvasScaler);
            }

            if (_canvasScaler.referenceResolution != global.Resolution)
            {
                _canvasScaler.referenceResolution = global.Resolution;
                MornAspectGlobal.Logger.Log("Resolutionのサイズ変更");
                MornAspectGlobal.SetDirty(_canvasScaler);
            }

            if (_canvasScaler.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
            {
                _canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                MornAspectGlobal.Logger.Log("ScreenMatchMode変更");
                MornAspectGlobal.SetDirty(_canvasScaler);
            }
        }
    }
}