﻿using trifenix.connect.mdm.enums;
namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Generación de menús en base a entidades.
    /// se identifica un menú con un identificador y se determina el dispositivo.
    /// </summary>
    public class GroupMenu {
        /// <summary>
        /// índice que corresponde al menú.
        /// </summary>
        public string MenuIndex { get; set; }
        /// <summary>
        /// Tipo de dispositivo donde se aplicaría el menú.
        /// </summary>
        public PhisicalDevice Device { get; set; }
        /// <summary>
        /// índice que identifica un submenú.
        /// </summary>
        public string SubMenuIndex { get; set; }

        /// <summary>
        /// Un nombre para agrupar un menú, puede existir más de uno.
        /// </summary>
        public string Name { get; set; }
    }
}
