using NettrimCHModels.Recursos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHServices.RecursoService
{
    public interface IGetRecurso
    {
        List<Recurso> GetRecurso();
    }
}
