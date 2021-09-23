using System.Collections.Generic;
using COVID.App.Dominio;

namespace COVID.App.Persistencia 
{
    public interface  IRepositorioProfesor
    {
         //GetAllProfesores
        
        IEnumerable<Profesor> GetAllProfesores();
        //AddProfesor
        Profesor AddProfesor(Profesor profesor);
        //UpdateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        //DeleteProfesor
        void DeleteProfesor(int idProfesor);
        //GetProfesor
        Profesor GetProfesor(int idProfesor);
    }
}