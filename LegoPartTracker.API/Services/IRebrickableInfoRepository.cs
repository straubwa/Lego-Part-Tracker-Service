﻿using System.Collections.Generic;

namespace LegoPartTracker.API.Services
{
    public interface IRebrickableInfoRepository
    {
        Entities.Rebrickable.Set GetSet(string setNumber);
        List<Entities.Rebrickable.SetPart> GetSetParts(string setNumber);
        Entities.Rebrickable.Theme GetTheme(int id);
        List<Entities.Rebrickable.Theme> GetAllThemes();
        List<Entities.Rebrickable.PartCategory> GetAllPartCategories();
    }
}