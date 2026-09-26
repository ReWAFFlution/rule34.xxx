// SPDX-License-Identifier: AGPL-3.0-or-later

using System.Numerics;
using Content.Shared._Arcane.Spline;
using Content.Shared._Arcane.Trail;
using Vector4 = System.Numerics.Vector4;

namespace Content.Server._Arcane.Trail;

[RegisterComponent]
public sealed partial class BulletTrailComponent : SharedBulletTrailComponent
{
    public BulletTrailComponent()
    {
        var defaultTrail = TrailSettings.Default;
        Enabled = defaultTrail.Enabled;
        Scale = defaultTrail.Scale;
        СreationDistanceThresholdSquared = defaultTrail.СreationDistanceThresholdSquared;
        CreationMethod = defaultTrail.CreationMethod;
        CreationOffset = defaultTrail.CreationOffset;
        Gravity = defaultTrail.Gravity;
        MaxRandomWalk = defaultTrail.MaxRandomWalk;
        Lifetime = defaultTrail.Lifetime;
        TexurePath = defaultTrail.TexurePath;
        Gradient = defaultTrail.Gradient;
        GradientIteratorType = defaultTrail.GradientIteratorType;
        OptionsConcealable = defaultTrail.OptionsConcealable;
    }

    public override Vector2 Gravity { get; set; }

    public override float Lifetime { get; set; }

    public override Vector2 MaxRandomWalk { get; set; }

    public override Vector2 Scale { get; set; }

    public override string? TexurePath { get; set; }

    public override Vector2 CreationOffset { get; set; }

    public override float СreationDistanceThresholdSquared { get; set; }

    public override SegmentCreationMethod CreationMethod { get; set; }

    public override Vector4[] Gradient { get; set; }

    public override float LengthStep { get; set; }

    public override Spline2DType SplineIteratorType { get; set; }

    public override TrailSplineRendererType SplineRendererType { get; set; }

    public override Spline4DType GradientIteratorType { get; set; }

    public override bool OptionsConcealable { get; set; }
}
