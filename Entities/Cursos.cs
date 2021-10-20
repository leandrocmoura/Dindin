using System;
using System.Collections.Generic;

namespace Entities
{
    public class Cursos
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public Professores Professores { get; set; }

        public string Descricao { get; set; }

        public List<Aulas> Aulas { get; set; }
    }
}
