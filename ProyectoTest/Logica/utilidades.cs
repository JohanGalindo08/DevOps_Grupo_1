﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoTest.Logica
{
    public class utilidades
    {
        public static string convertirBase64(string ruta) {
            byte[] bytes = File.ReadAllBytes(ruta);
            string file = Convert.ToBase64String(bytes);
            return file;
        }
    }
<<<<<<< HEAD
}

=======
}
>>>>>>> bfa03de5ce5317cadb11a56dfda7c7f899918476
