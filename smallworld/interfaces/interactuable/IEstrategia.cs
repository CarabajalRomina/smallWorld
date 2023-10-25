﻿using smallworld.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallworld.interfaces.interactuable
{
    public interface IEstrategia
    {
        public void AplicarEfecto(Entidad entidad);
    }
}
