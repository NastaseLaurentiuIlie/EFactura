﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.ConfigSettings
{
    public class Config
    {

        public string Endpoint { get; set; }
        public string Port { get; set; }
        public string Username { get; set;}
        public string Password { get; set; }
        public string Database { get; set; }
        public override string ToString()
        {
            return $"Endpoint: {Endpoint}, Port: {Port}, Username: {Username}, Password: {Password}, Database: {Database}";
        }
    }
}
