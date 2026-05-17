using MyelomaCareGuard.Models;
using MyelomaCareGuard.Services.Interfaces;

namespace MyelomaCareGuard.Services
{
    public class RecordMetadataService : IRecordMetadataService
    {
        private static readonly Dictionary<RecordType, RecordMetadata> _metadata = new()
        {
            { RecordType.MProtein, new RecordMetadata { Unit = "g/L", Min = 0, Max = 0 } },
            { RecordType.KappaLightChain, new RecordMetadata { Unit = "mg/L", Min = 3.30, Max = 19.40 } },
            { RecordType.WhiteBloodCell, new RecordMetadata { Unit = "10^9/L", Min = 3.50, Max = 9.50 } }
            /*{ RecordType.LambdaLightChain, new RecordMetadata { Unit = "mg/L", Min = 5.70, Max = 26.30 } },
            { RecordType.WhiteBloodCell, new RecordMetadata { Unit = "10^9/L", Min = 3.50, Max = 9.50 } },
            { RecordType.Hemoglobin, new RecordMetadata { Unit = "g/L", Min = 115, Max = 150 } },
            { RecordType.Creatinine, new RecordMetadata { Unit = "μmol/L", Min = 41, Max = 81 } },
            { RecordType.Calcium, new RecordMetadata { Unit = "mmol/L", Min = 2.11, Max = 2.41} },
            { RecordType.Beta2Microglobulin, new RecordMetadata { Unit = "mg/L", Min = 1.30, Max = 3.00 } }*/
        };
        public RecordMetadata GetMetadata(RecordType type)
        {
            if (_metadata.TryGetValue(type, out var metadata))
            {
                return metadata;
            }
            throw new ArgumentException($"No metadata found for record type: {type}");
        }

    }
}