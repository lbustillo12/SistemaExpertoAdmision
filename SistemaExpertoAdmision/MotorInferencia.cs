using System;
using System.Collections.Generic;

namespace SistemaExpertoAdmision
{
    public class MotorInferencia
    {
        private List<Regla> baseDeConocimientos;

        public MotorInferencia()
        {
            baseDeConocimientos = new List<Regla>();
            CargarReglas();
        }

        private void CargarReglas()
        {
            //Reglas
            baseDeConocimientos.Add(new Regla { Id = 1, Condicion = h => h.NotaMatematica < 50 && h.NotaPsicologica < 50, Conclusion = "Rechazado" });
            baseDeConocimientos.Add(new Regla { Id = 3, Condicion = h => h.NotaMatematica > 90 && h.NotaPsicologica > 90, Conclusion = "Beca completa" });
            baseDeConocimientos.Add(new Regla { Id = 2, Condicion = h => h.NotaMatematica > 80 && h.NotaPsicologica > 80, Conclusion = "Media beca" });
            baseDeConocimientos.Add(new Regla { Id = 4, Condicion = h => h.NotaMatematica > 80 && h.NotaPsicologica < 70, Conclusion = "Matrícula condicionada" });
            baseDeConocimientos.Add(new Regla { Id = 5, Condicion = h => h.NotaMatematica < 70 && h.NotaPsicologica > 80, Conclusion = "Matrícula con reforzamiento" });
            baseDeConocimientos.Add(new Regla { Id = 6, Condicion = h => true, Conclusion = "Matrícula normal" });
        }

        public string Evaluar(HechoAspirante hechos)
        {
            foreach (var regla in baseDeConocimientos)
            {
                if (regla.Condicion(hechos))
                {
                    return regla.Conclusion;
                }
            }
            return "No determinado";
        }
    }
}