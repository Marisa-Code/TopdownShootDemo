using Entitas.Unity;
using UnityEngine;

public class BulletView : View, IPhysicsView
{
    [SerializeField] private Rigidbody2D _rigidbody;

    public Rigidbody2D Rigidbody => _rigidbody;

    protected override void OnDestroyEntityHandler()
    {
        PoolManager.Instance.Recycle(this, ActorTag.Bullet);
    }
}