﻿using System;
using System.Collections.Generic;


namespace Grados
{
    class LibroDeCalifiaciones
    {
        public void AddCalificacion(float calificacion)
        {
            calificaciones.Add(calificacion);
        }
        List<float> calificaciones = new List<float>();
    }

}
