﻿using F23L055_GestToDo.Bll.Entities;

namespace F23L055_GestToDo.Bll.Repositories
{
    public interface ITacheRepository
    {
        IEnumerable<Tache> Get();
        bool CreerTache(Tache tache);
    }
}
