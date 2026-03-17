using net01.Dominio.Enums;
using net01.Dominio.Exceptions;
using net01.Dominio.ObjectValue;

namespace net01.Dominio.Entities
{
    public class Cita
    {
        public Guid Id { get; private set; }
        public Guid PacienteId { get; private set; }
        public Guid DentistaId { get; private set; }
        public Guid ConsultorioId { get; private set; }
        public EstadoCita Estado { get; private set; }
        public IntervalTime IntervalTime{ get; private set; }
        public Paciente? Paciente { get; private set; }
        public Dentista? Dentista { get; private set; }
        public Consultorio? Consultorio { get; private set; }

        public Cita(Guid pacienteId, Guid dentistaId, Guid consultorioId, IntervalTime intervalTime)
        {

            if (intervalTime.FechaInicio < DateTime.UtcNow)
            {
                throw new DomainRulesException($"La fecha inicio no puede ser anterior a la fecha actual");
            }

            PacienteId = pacienteId;
            DentistaId = dentistaId;
            ConsultorioId = consultorioId;
            IntervalTime = intervalTime;
            Estado = EstadoCita.Programada;
            Id = Guid.CreateVersion7();
        }

        public void Cancel()
        {
            if(Estado != EstadoCita.Programada)
            {
                throw new DomainRulesException($"Solo se puede cancelar citas programadas.");
            }
            Estado = EstadoCita.Cancelada;
        }

        public void Complete()
        {
            if (Estado != EstadoCita.Programada)
            {
                throw new DomainRulesException($"Solo se puede completar citas programadas.");
            }
            Estado = EstadoCita.Completada;
        }

    }
}
