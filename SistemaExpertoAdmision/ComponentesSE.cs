using System;

namespace SistemaExpertoAdmision
{
    public class HechoAspirante
    {
        public double NotaMatematica { get; set; }
        public double NotaPsicologica { get; set; }
    }

    public class Regla
    {
        public int Id { get; set; }
        public Predicate<HechoAspirante> Condicion { get; set; }
        public string Conclusion { get; set; }
    }
}