using si730pc2u202213765.API.CRM.Domain.Model.Aggregates;
using si730pc2u202213765.API.CRM.Domain.Model.Commands;
using si730pc2u202213765.API.CRM.Domain.Repositories;
using si730pc2u202213765.API.CRM.Domain.Services;
using si730pc2u202213765.API.Shared.Domain.Model.Repositories;

namespace si730pc2u202213765.API.CRM.Application.Internal.CommandServices;

public class LeadCommandService(ILeadRepository leadRepository, IUnitOfWork unitOfWork) : ILeadCommandService
{
    /// <summary>
    /// Maneja el comando de creación de un nuevo Lead.
    /// Aplica las reglas de negocio necesarias y persiste el nuevo Lead en el sistema.
    /// </summary>
    /// <param name="command">Comando que contiene la información necesaria para crear el Lead.</param>
    /// <returns>El Lead creado o null si falla la operación (por ejemplo, si usas excepciones para errores).</returns>
    public async Task<Lead?> Handle(CreateLeadCommand command)
    {
        var lead = new Lead(command);
        // Persistir el nuevo Lead en el repositorio.
        await leadRepository.AddAsync(lead);
        // Confirmar la transacción con la unidad de trabajo.
        // Esto asegura que los cambios se guarden en la base de datos.
        await unitOfWork.CompleteAsync();
        // Retornar el Lead creado, que puede ser útil para construir el response en el controlador.
        return lead;
    }
}