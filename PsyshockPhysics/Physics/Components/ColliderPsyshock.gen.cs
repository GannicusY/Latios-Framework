﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     TextTransform Collider.tt
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Latios.Psyshock
{
    public unsafe partial struct Collider : IComponentData
    {
        public static implicit operator Collider(SphereCollider sphereCollider)
        {
            Collider collider = default;
            collider.m_type   = ColliderType.Sphere;
            collider.m_sphere = sphereCollider;
            return collider;
        }

        public static implicit operator SphereCollider(Collider collider)
        {
            CheckColliderIsCastTargetType(in collider, ColliderType.Sphere);
            return collider.m_sphere;
        }

        public static implicit operator Collider(CapsuleCollider capsuleCollider)
        {
            Collider collider  = default;
            collider.m_type    = ColliderType.Capsule;
            collider.m_capsule = capsuleCollider;
            return collider;
        }

        public static implicit operator CapsuleCollider(Collider collider)
        {
            CheckColliderIsCastTargetType(in collider, ColliderType.Capsule);
            return collider.m_capsule;
        }

        public static implicit operator Collider(BoxCollider boxCollider)
        {
            Collider collider = default;
            collider.m_type   = ColliderType.Box;
            collider.m_box    = boxCollider;
            return collider;
        }

        public static implicit operator BoxCollider(Collider collider)
        {
            CheckColliderIsCastTargetType(in collider, ColliderType.Box);
            return collider.m_box;
        }

        public static implicit operator Collider(TriangleCollider triangleCollider)
        {
            Collider collider   = default;
            collider.m_type     = ColliderType.Triangle;
            collider.m_triangle = triangleCollider;
            return collider;
        }

        public static implicit operator TriangleCollider(Collider collider)
        {
            CheckColliderIsCastTargetType(in collider, ColliderType.Triangle);
            return collider.m_triangle;
        }

        public static implicit operator Collider(ConvexCollider convexCollider)
        {
            Collider collider = default;
            collider.m_type   = ColliderType.Convex;
            collider.m_convex = convexCollider;
            return collider;
        }

        public static implicit operator ConvexCollider(Collider collider)
        {
            CheckColliderIsCastTargetType(in collider, ColliderType.Convex);
            return collider.m_convex;
        }

        public static implicit operator Collider(CompoundCollider compoundCollider)
        {
            Collider collider   = default;
            collider.m_type     = ColliderType.Compound;
            collider.m_compound = compoundCollider;
            return collider;
        }

        public static implicit operator CompoundCollider(Collider collider)
        {
            CheckColliderIsCastTargetType(in collider, ColliderType.Compound);
            return collider.m_compound;
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        internal static void CheckColliderIsCastTargetType(in Collider c, ColliderType targetType)
        {
            if (c.m_type != targetType)
            {
                switch (targetType)
                {
                    case ColliderType.Sphere: throw new InvalidOperationException("Collider is not a SphereCollider but is being casted to one.");
                    case ColliderType.Capsule: throw new InvalidOperationException("Collider is not a CapsuleCollider but is being casted to one.");
                    case ColliderType.Box: throw new InvalidOperationException("Collider is not a BoxCollider but is being casted to one.");
                    case ColliderType.Triangle: throw new InvalidOperationException("Collider is not a TriangleCollider but is being casted to one.");
                    case ColliderType.Convex: throw new InvalidOperationException(
                            "Collider is not a ConvexCollider but is being casted to one. Unlike Unity.Physics, ConvexColliders do not aggregate Spheres, Capsules, Boxes, or Triangles.");
                    case ColliderType.Compound: throw new InvalidOperationException("Collider is not a CompoundCollider but is being casted to one.");
                }
            }
        }
    }
}

