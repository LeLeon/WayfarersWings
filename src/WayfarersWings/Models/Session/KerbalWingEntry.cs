﻿using KSP.Sim.impl;
using UnityEngine.Serialization;
using WayfarersWings.Managers;
using WayfarersWings.Models.Wings;

namespace WayfarersWings.Models.Session;

public class KerbalWingEntry
{
    public Wing Wing;
    public IGGuid KerbalId;
    public DateTime UnlockedAt;
    public double UniverseTime;

    public KerbalWingEntry(Wing wing, IGGuid kerbalId, DateTime unlockedAt, double universeTime)
    {
        Wing = wing;
        KerbalId = kerbalId;
        UnlockedAt = unlockedAt;
        this.UniverseTime = universeTime;
    }

    public KerbalWingEntry(IGGuid kerbalId)
    {
        Wing = Core.Instance.WingsPool.FindWingByCode(data.wingCode);
        KerbalId = kerbalId;
        UnlockedAt = data.unlockedAt;
        UniverseTime = data.universeTime;
    }

    public sta
}