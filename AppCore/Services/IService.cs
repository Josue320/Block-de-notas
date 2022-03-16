using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    interface IService <T>
    {
        T Create(String t);
        string Read(string nota);
    }
}
