//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PhysicsContext {

    public PhysicsEntity physicsCompEntity { get { return GetGroup(PhysicsMatcher.PhysicsComp).GetSingleEntity(); } }
    public PhysicsComp physicsComp { get { return physicsCompEntity.physicsComp; } }
    public bool hasPhysicsComp { get { return physicsCompEntity != null; } }

    public PhysicsEntity SetPhysicsComp(System.Collections.Generic.List<CollisionInfo> newCollisionInfos) {
        if (hasPhysicsComp) {
            throw new Entitas.EntitasException("Could not set PhysicsComp!\n" + this + " already has an entity with PhysicsComp!",
                "You should check if the context already has a physicsCompEntity before setting it or use context.ReplacePhysicsComp().");
        }
        var entity = CreateEntity();
        entity.AddPhysicsComp(newCollisionInfos);
        return entity;
    }

    public void ReplacePhysicsComp(System.Collections.Generic.List<CollisionInfo> newCollisionInfos) {
        var entity = physicsCompEntity;
        if (entity == null) {
            entity = SetPhysicsComp(newCollisionInfos);
        } else {
            entity.ReplacePhysicsComp(newCollisionInfos);
        }
    }

    public void RemovePhysicsComp() {
        physicsCompEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PhysicsEntity {

    public PhysicsComp physicsComp { get { return (PhysicsComp)GetComponent(PhysicsComponentsLookup.PhysicsComp); } }
    public bool hasPhysicsComp { get { return HasComponent(PhysicsComponentsLookup.PhysicsComp); } }

    public void AddPhysicsComp(System.Collections.Generic.List<CollisionInfo> newCollisionInfos) {
        var index = PhysicsComponentsLookup.PhysicsComp;
        var component = (PhysicsComp)CreateComponent(index, typeof(PhysicsComp));
        component.CollisionInfos = newCollisionInfos;
        AddComponent(index, component);
    }

    public void ReplacePhysicsComp(System.Collections.Generic.List<CollisionInfo> newCollisionInfos) {
        var index = PhysicsComponentsLookup.PhysicsComp;
        var component = (PhysicsComp)CreateComponent(index, typeof(PhysicsComp));
        component.CollisionInfos = newCollisionInfos;
        ReplaceComponent(index, component);
    }

    public void RemovePhysicsComp() {
        RemoveComponent(PhysicsComponentsLookup.PhysicsComp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class PhysicsMatcher {

    static Entitas.IMatcher<PhysicsEntity> _matcherPhysicsComp;

    public static Entitas.IMatcher<PhysicsEntity> PhysicsComp {
        get {
            if (_matcherPhysicsComp == null) {
                var matcher = (Entitas.Matcher<PhysicsEntity>)Entitas.Matcher<PhysicsEntity>.AllOf(PhysicsComponentsLookup.PhysicsComp);
                matcher.componentNames = PhysicsComponentsLookup.componentNames;
                _matcherPhysicsComp = matcher;
            }

            return _matcherPhysicsComp;
        }
    }
}
