using System.ComponentModel.DataAnnotations;

namespace VulpesFormsApp.Models;

public class NewBookingFormModel
{
    [Required(ErrorMessage = "Please select plaintiff type")]
    public string PlaintiffType { get; set; } = "";

    public string NamePrefix { get; set; } = "";

    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = "";

    public string MiddleName { get; set; } = "";

    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = "";

    public string NameSuffix { get; set; } = "";
    public string PlaintiffIdNumber { get; set; } = "";
    public string KnowsReference { get; set; } = "";
    public string VulpesReferenceNumber { get; set; } = "";
    public string PlaintiffIdForExisting { get; set; } = "";
    public string AssessmentDate { get; set; } = "";
    public string Location { get; set; } = "";
    public string AttorneyFirm { get; set; } = "";
    public string AttorneyReference { get; set; } = "";
    public string InstructingAttorneyPrefix { get; set; } = "";
    public string InstructingAttorneyFirst { get; set; } = "";
    public string InstructingAttorneyLast { get; set; } = "";
    public string InstructingDate { get; set; } = "";
    public string Notes { get; set; } = "";

    public List<ServiceRow> Services { get; set; } = new();
}

public class ServiceRow
{
    public string Service { get; set; } = "";
    public string Active { get; set; } = "";
    public string AssessmentDate { get; set; } = "";
    public string AssessmentTime { get; set; } = "";
    public string NotifyEmail { get; set; } = "";
}