using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalvadorVillanuevaRamirez
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
            a.git reset --soft HEAD~1: Este comando deshace el último commit pero mantiene los cambios en el área de preparación(staging).Básicamente, "deshace" el commit sin perder los cambios.

            b.git restore --staged.: Este comando quita los cambios del área de preparación(staging) y los coloca de nuevo en el directorio de trabajo. Es útil si has agregado archivos al área de preparación y deseas quitarlos antes de hacer un commit.

            c.git restore .: Este comando descarta los cambios en el directorio de trabajo y los restaura a la versión más reciente del repositorio. Ten cuidado con este comando, ya que perderás los cambios no guardados.

            d.git clean -f: Este comando elimina archivos no rastreados en el directorio de trabajo.La opción -f es para forzar la eliminación sin confirmación, así que úsalo con precaución.

            e.git merge --abort: Este comando cancela una fusión en progreso y vuelve al estado anterior a la fusión.Es útil si te encuentras en medio de una fusión y algo sale mal; con esto, puedes retroceder sin fusionar los cambios.
        */
        }
    }
}
