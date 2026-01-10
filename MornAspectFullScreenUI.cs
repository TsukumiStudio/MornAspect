using UnityEngine;

namespace MornLib
{
    [RequireComponent(typeof(RectTransform))]
    internal sealed class MornAspectFullScreenUI : MornAspectComponentBase
    {
        [SerializeField, Tooltip("コンテンツ(null可)")] private RectTransform _rect;

        private void Reset()
        {
            _rect = GetComponent<RectTransform>();
        }

        protected override void AdjustAspect()
        {
            if (!TryGetGlobal(out var global)) return;
            if (_rect != null && _rect.sizeDelta != global.Resolution)
            {
                _rect.sizeDelta = global.Resolution;
                MornAspectGlobal.LogAndSetDirty("サイズ変更", _rect);
            }
        }
    }
}