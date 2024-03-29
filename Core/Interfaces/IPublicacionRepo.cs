﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPublicacionRepo
    {
        Task<IEnumerable<Publicacion>> GetPublicaciones();
        Task<Publicacion> GetPublicacion(int id);
        Task InsertPublicacion(Publicacion pub);
        Task<bool> UpdatePublicacion(Publicacion publicacion);
        Task<bool> DeletePublicacion(int id);
    }
}
