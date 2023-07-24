using UnityEngine;

namespace Game01
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class TargetColorSetter : MonoBehaviour
    {
        [SerializeField] private Color _targetColor;

        private SpriteRenderer _renderer;

        private void Awake()
        {
            TryGetComponent(out _renderer);
        }

        public void Change()
        {
            _renderer.color = _targetColor;
        }
    }
}
