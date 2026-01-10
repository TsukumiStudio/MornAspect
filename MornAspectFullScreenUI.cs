using UnityEngine;

namespace MornLib
{
    [RequireComponent(typeof(RectTransform))]
    internal sealed class MornAspectFullScreenUI : MornAspectComponentBase
    {
        private RectTransform _rect;

        protected override void AdjustAspect()
        {
            if (_rect == null) _rect = GetComponent<RectTransform>();
            if (!TryGetGlobal(out var global)) return;
            if (_rect != null && _rect.sizeDelta != global.Resolution)
            {
                _rect.sizeDelta = global.Resolution;
                MornAspectGlobal.LogAndSetDirty("サイズ変更", _rect);
            }
        }
    }
}