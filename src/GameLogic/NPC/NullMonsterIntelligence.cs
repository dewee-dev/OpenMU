﻿// <copyright file="NullMonsterIntelligence.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.NPC;

using MUnique.OpenMU.Pathfinding;

/// <summary>
/// The monster intelligence which does nothing.
/// </summary>
public sealed class NullMonsterIntelligence : INpcIntelligence
{
    private NonPlayerCharacter? _npc;

    /// <inheritdoc />
    public NonPlayerCharacter Npc
    {
        get => this._npc ?? throw Error.NotInitializedProperty(this);
        set => this._npc = value;
    }

    /// <inheritdoc />
    public bool CanWalkOnSafezone => false;

    /// <inheritdoc />
    public void RegisterHit(IAttacker attacker)
    {
        // do nothing
    }

    /// <inheritdoc />
    public void Start()
    {
        // do nothing
    }

    /// <inheritdoc />
    public void Pause()
    {
        // do nothing
    }

    /// <summary>
    /// If Null Monster can walk on target.
    /// </summary>
    /// <param name="target">The target.</param>
    public bool CanWalkOn(Point target)
    {
        return false;
    }
}