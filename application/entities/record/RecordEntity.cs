namespace Application.Entities.Record;

public class RecordEntity
{
    private string? _code { get; set; }
    private string? _codeMaterial { get; set; }
    private string? _engCode { get; set; }
    private string? __createdBy { get; set; }
    private string? _creationDate { get; set; }
    private string? _center { get; set; }
    private string? _image { get; set; }
    private string? _knowledge { get; set; }
    private string? _lt_alternative { get; set; }
    private string? _distribution { get; set; }
    private string? _description { get; set; }
    private string? _typeRecord { get; set; }
    private string? _implatation { get; set; }
    private string? _observation { get; set; }
    private string? _revition { get; set; }
    private bool? _statusForm { get; set; }
    private int? _version { get; set; }
    private string? _statusWorkflow { get; set; }
    private bool? active { get; set; }
    private Finished? _finishedRecord { get; set; }
    private Grid? _gridRecord { get; set; }
    private Plate? _plateRecord { get; set; }
    private Mounted? _mountedRecord { get; set; }
    private List<Component>? _components { get; set; }
}