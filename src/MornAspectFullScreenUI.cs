using UnityEngine;

namespace MornLib
{
    [RequireComponent(typeof(RectTransform))]
    internal sealed class MornAspectFullScreenUI : MornAspectComponentBase
    {
        [SerializeField, HideInInspector] private RectTransform _rect;

        private void Reset()
        {
            _rect = GetComponent<RectTransform>();
        }

        protected override void AdjustAspect()
        {
            if (!TryGetGlobal(out var global)) return;
            if (_rect == null) return;
            if (_rect.sizeDelta != global.Resolution)
            {
                _rect.sizeDelta = global.Resolution;
                MornAspectGlobal.Logger.Log("サイズ変更");
                MornGlobalUtil.SetDirty(_rect);
            }
        }
    }
}