using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] float _speed;

    private readonly RaycastHit2D[] _results = new RaycastHit2D[1];
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    private void Awake()
    {
        //_rigidbody2D = GetComponent<Rigidbody2D>();
        TryGetComponent(out _rigidbody2D);
    }

    private void Start()
    {
        TryGetComponent(out _animator);
    }

    private void FixedUpdate()
    {
        int collisionCount = _rigidbody2D.Cast(transform.right, _filter, _results, 10);
        //Debug.Log(collisionCount);

        if (collisionCount == 0)
        {
            _rigidbody2D.velocity = transform.right * _speed;
            _animator.SetBool("Moving", true);
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
            _animator.SetBool("Moving", false);
        }
    }
}
