using UnityEngine;
using UnityEngine.UI;

namespace MornLib
{
    [RequireComponent(typeof(CanvasScaler))]
    internal sealed class MornAspectCanvas : MornAspectComponentBase
    {
        [SerializeField, HideInInspector] private CanvasScaler _canvasScaler;

        private void Reset()
        {
            _canvasScaler = GetComponent<CanvasScaler>();
        }

        protected override void AdjustAspect()
        {
            if (!TryGetGlobal(out var global)) return;
            if (_canvasScaler == null) return;
            var changed = false;
            if (_canvasScaler.uiScaleMode != CanvasScaler.ScaleMode.ScaleWithScreenSize)
            {
                _canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                changed = true;
            }

            if (_canvasScaler.referenceResolution != global.Resolution)
            {
                _canvasScaler.referenceResolution = global.Resolution;
                changed = true;
            }

            if (_canvasScaler.screenMatchMode != CanvasScaler.ScreenMatchMode.Expand)
            {
                _canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                changed = true;
            }

            if (changed)
            {
                MornAspectGlobal.Logger.Log("CanvasScaler設定変更");
                MornGlobalUtil.SetDirty(_canvasScaler);
            }
        }
    }
}