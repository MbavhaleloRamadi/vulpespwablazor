using System.ComponentModel.DataAnnotations;

namespace VulpesFormsApp.Models;

public class AttorneysFormModel
{
    [Required(ErrorMessage = "Your name is required")]
    public string YourName { get; set; } = "";

    [Required(ErrorMessage = "Firm name is required")]
    public string FirmName { get; set; } = "";

    [Required(ErrorMessage = "Attorney code is required")]
    public string AttorneyCode { get; set; } = "";

    public List<ContactRow> FirmContacts { get; set; } = new();

    public bool SlaCash { get; set; }
    public bool SlaDeposit { get; set; }
    public bool SlaContingency { get; set; }
}

public class ContactRow
{
    public string Role { get; set; } = "";
    public string NameAndSurname { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
}