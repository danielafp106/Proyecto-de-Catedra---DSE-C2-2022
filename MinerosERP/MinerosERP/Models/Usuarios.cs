﻿namespace MinerosERP.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int id_rol_usuario { get; set; }
    }
}
