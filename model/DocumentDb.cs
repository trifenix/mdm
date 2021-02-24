﻿using System;
using System.Collections.Generic;
using System.Text;

namespace trifenix.model
{
    /// <summary>
    /// Documentos de la Base de datos
    /// </summary>
    public abstract class DocumentDb
    {
        /// <summary>
        /// Todos los elementos debene llevar un identificador
        /// </summary>
        /// <value>identificador de un elemento de base de datos</value>
        public abstract string Id { get; set; }

        /// <summary>
        /// Identificador que solo el usuario puede ver, esto puede ser un autonumérico.
        /// </summary>
        /// <value></value>
        public abstract string ClientId { get; set; }

        /// <summary>
        /// Indicador de estado de la entidad
        /// </summary>
        public abstract bool State { get; set; }

    }
}