using UnityEngine;

namespace MornLib
{
    [CreateAssetMenu(fileName = nameof(MornAspectGlobal), menuName = "Morn/" + nameof(MornAspectGlobal))]
    internal sealed class MornAspectGlobal : MornGlobalBase<MornAspectGlobal>
    {
        protected override string ModuleName => "MornAspect";
        [SerializeField, Tooltip("基準解像度")]
        private Vector2 _resolution = new(1920, 1080);
        public Vector2 Resolution => _resolution;

        internal static void SetDirty(Object obj)
        {
            I.SetDirtyInternal(obj);
        }
    }
}