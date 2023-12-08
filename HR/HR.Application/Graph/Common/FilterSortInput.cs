using HR.CrossCutting.Enum;
using HR.Infrastructure.SearchEngine.Models;

namespace HR.Application.Graph.Common;
public record FilterSortInput(Dictionary<ObjectType, List<FilterItem>>? Filters, BizObjectSort? MainSort);