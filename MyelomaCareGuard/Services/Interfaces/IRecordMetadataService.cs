using MyelomaCareGuard.Models;

namespace MyelomaCareGuard.Services.Interfaces
{
    public interface IRecordMetadataService
    {
        RecordMetadata GetMetadata(RecordType type);
    }
}
